﻿using System.Drawing;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ZTn.Json.Editor.Forms
{
    public sealed partial class JsonEditorMainForm : Form
    {
        private const string DefaultFileFilters = @"json files (*.json)|*.json";

        #region >> Delegates

        private delegate void SetActionStatusDelegate(string text, bool isError);

        private delegate void SetJsonStatusDelegate(string text, bool isError);

        #endregion

        #region >> Fields

        private string internalOpenedFileName;

        private System.Timers.Timer jsonValidationTimer;

        #endregion

        #region >> Properties

        /// <summary>
        /// Accessor to file name of opened file.
        /// </summary>
        string OpenedFileName
        {
            get { return internalOpenedFileName; }
            set
            {
                internalOpenedFileName = value;
                saveToolStripMenuItem.Enabled = internalOpenedFileName != null;
                saveAsToolStripMenuItem.Enabled = internalOpenedFileName != null;
                Text = (internalOpenedFileName ?? "") + @" - Json Editor by ZTn";
            }
        }

        #endregion

        #region >> Constructor

        public JsonEditorMainForm()
        {
            InitializeComponent();

            jsonTypeComboBox.DataSource = Enum.GetValues(typeof(JTokenType));

            OpenedFileName = null;
            SetActionStatus(@"Empty document.", true);
            SetJsonStatus(@"", false);

            var commandLineArgs = Environment.GetCommandLineArgs();
            if (commandLineArgs.Skip(1).Any())
            {
                OpenedFileName = commandLineArgs[1];
                try
                {
                    using (var stream = new FileStream(commandLineArgs[1], FileMode.Open))
                    {
                        SetJsonSourceStream(stream, commandLineArgs[1]);
                    }
                }
                catch
                {
                    OpenedFileName = null;
                }
            }
            //auto create empty object
            newJsonObjectToolStripMenuItem_Click(this, null);

        }

        #endregion

        #region >> Form

        /// <inheritdoc />
        /// <remarks>
        /// Optimization aiming to reduce flickering on large documents (successfully).
        /// Source: http://stackoverflow.com/a/89125/1774251
        /// </remarks>
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;    // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        #endregion

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = @"json files (*.json)|*.json|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var stream = openFileDialog.OpenFile())
                {
                    SetJsonSourceStream(stream, openFileDialog.FileName);
                }

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenedFileName == null)
            {
                return;
            }

            try
            {
                using (var stream = new FileStream(OpenedFileName, FileMode.Open))
                {
                    jTokenTree.SaveJson(stream);
                }
            }
            catch
            {
                MessageBox.Show(this, $"An error occured when saving file as \"{OpenedFileName}\".", @"Save As...");

                OpenedFileName = null;
                SetActionStatus(@"Document NOT saved.", true);

                return;
            }

            SetActionStatus(@"Document successfully saved.", false);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = DefaultFileFilters,
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                OpenedFileName = saveFileDialog.FileName;
                using (var stream = saveFileDialog.OpenFile())
                {
                    if (stream.CanWrite)
                    {
                        jTokenTree.SaveJson(stream);
                    }
                }
            }
            catch
            {
                MessageBox.Show(this, $"An error occured when saving file as \"{OpenedFileName}\".", @"Save As...");

                OpenedFileName = null;
                SetActionStatus(@"Document NOT saved.", true);

                return;
            }

            SetActionStatus(@"Document successfully saved.", false);
        }

        private void newJsonObjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jTokenTree.SetJsonSource("{}");

            saveAsToolStripMenuItem.Enabled = true;
            SetActionStatus(@"Document Loaded", false);
        }

        private void newJsonArrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jTokenTree.SetJsonSource("[]");

            saveAsToolStripMenuItem.Enabled = true;
        }

        private void aboutJsonEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }

        private void jsonValueTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!isValidating)
            {
                StartValidationTimer();
            }
        }

        private void jsonValueTextBox_Leave(object sender, EventArgs e)
        {
            jsonValueTextBox.TextChanged -= jsonValueTextBox_TextChanged;
        }

        private void jsonValueTextBox_Enter(object sender, EventArgs e)
        {
            jsonValueTextBox.TextChanged += jsonValueTextBox_TextChanged;
        }

        private void jTokenTree_AfterSelect(object sender, JsonTreeView.AfterSelectEventArgs eventArgs)
        {
            newtonsoftJsonTypeTextBox.Text = eventArgs.TypeName;

            jsonTypeComboBox.Text = eventArgs.JTokenTypeName;

            // If jsonValueTextBox is focused then it triggers this event in the update process, so don't update it again ! (risk: infinite loop between events).
            if (!jsonValueTextBox.Focused)
            {
                jsonValueTextBox.Text = eventArgs.GetJsonString();
            }
        }

        private void SetJsonSourceStream(Stream stream, string fileName)
        {
            if (stream == null)
            {
                throw new ArgumentNullException(nameof(stream));
            }

            OpenedFileName = fileName;

            try
            {
                jTokenTree.SetJsonSource(stream);
            }
            catch
            {
                MessageBox.Show(this, $"An error occured when reading \"{OpenedFileName}\"", @"Open...");

                OpenedFileName = null;
                SetActionStatus(@"Document NOT loaded.", true);

                return;
            }

            SetActionStatus(@"Document successfully loaded.", false);
            saveAsToolStripMenuItem.Enabled = true;
        }

        private void SetActionStatus(string text, bool isError)
        {
            if (InvokeRequired)
            {
                Invoke(new SetActionStatusDelegate(SetActionStatus), text, isError);
                return;
            }

            actionStatusLabel.Text = text;
            actionStatusLabel.ForeColor = isError ? Color.OrangeRed : Color.Black;
        }

        private void SetJsonStatus(string text, bool isError)
        {
            if (InvokeRequired)
            {
                Invoke(new SetJsonStatusDelegate(SetActionStatus), text, isError);
                return;
            }

            jsonStatusLabel.Text = text;
            jsonStatusLabel.ForeColor = isError ? Color.OrangeRed : Color.Black;
        }
        private bool isValidating;

        private void StartValidationTimer()
        {
            jsonValidationTimer?.Stop();

            jsonValidationTimer = new System.Timers.Timer(250);

            jsonValidationTimer.Elapsed += (o, args) =>
            {
                if (isValidating)
                {
                    return;
                }
                else
                {
                    isValidating = true;
                }

                jsonValidationTimer.Stop();

                jTokenTree.Invoke(new Action(JsonValidationTimerHandler));
                isValidating = false;

            };

            jsonValidationTimer.Start();
        }

        private void JsonValidationTimerHandler()
        {
            try
            {
                jTokenTree.UpdateSelected(jsonValueTextBox.Text);
                //reformat json to be pretty
                jsonValueTextBox.Text = JsonConvert.SerializeObject(
                    JsonConvert.DeserializeObject(jsonValueTextBox.Text),
                    Formatting.Indented);

                SetJsonStatus("Json format validated.", false);

            }
            catch (JsonReaderException exception)
            {
                SetJsonStatus(
                    $"INVALID Json format at (line {exception.LineNumber}, position {exception.LinePosition})",
                    true);
            }
            catch
            {
                SetJsonStatus("INVALID Json format", true);
            }
        }

        private void jsonValueTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //remove styles from richtextbox
            if (e.Control && e.KeyCode == Keys.V)
            {
                ((RichTextBox)sender).Paste(DataFormats.GetFormat("Text"));
                e.Handled = true;
            }
        }

        private void FindNextButton_Click(object sender, EventArgs e)
        {
            var ss = jTokenTree.jsonTreeView.Nodes.Find("", true).Where(n=>n.Text.Contains(searchBox.Text)).ToArray();
            var currentIndex = Array.IndexOf(ss, jTokenTree.jsonTreeView.SelectedNode);
            if (ss.Any()&& ss.Length> currentIndex + 1 )
            {
                  jTokenTree.jsonTreeView.SelectedNode = ss[currentIndex + 1]; 
            }
         
            //var tn = jTokenTree.jsonTreeView.NextNodes().FirstOrDefault(x => x.Text.Contains(searchBox.Text));

            //if (tn == null)
            //    MessageBox.Show("查找完毕");
            //else
            //    jTokenTree.jsonTreeView.SelectedNode = tn;
        }

        private void findPreviousButton_Click(object sender, EventArgs e)
        {
            var ss = jTokenTree.jsonTreeView.Nodes.Find("", true).Where(n => n.Text.Contains(searchBox.Text)).ToArray();
           var currentIndex= Array.IndexOf(ss, jTokenTree.jsonTreeView.SelectedNode);
           if (ss.Any() && ss.Length > currentIndex && currentIndex - 1>=0)
           {
               jTokenTree.jsonTreeView.SelectedNode = ss[currentIndex - 1];
           }

        }
    } 
}
