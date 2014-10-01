//  File__Input___40_in_45_memory_43_GUI_41_.cs
//
//  Author:
//       Victor L. Senior (VLS) <betselection(&)gmail.com>
//
//  Web: 
//       http://betselection.cc/betsoftware/
//
//  Sources:
//       http://github.com/betselection/
//
//  Copyright (c) 2014 Victor L. Senior
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

/// <summary>
/// File Input (in-memory+GUI).
/// </summary>
namespace File__Input___40_in_45_memory_43_GUI_41_
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Reflection;
    using System.Windows.Forms;

    /// <summary>
    /// File Input (in-memory+GUI) class.
    /// </summary>
    public class File__Input___40_in_45_memory_43_GUI_41_ : Form
    {
        /// <summary>
        /// List of string for file lines
        /// </summary>
        private List<string> lines = new List<string>();

        /// <summary>
        /// List pointer
        /// </summary>
        private int pointer = 0;

        /// <summary>
        /// The marshal object.
        /// </summary>
        private object marshal = null;

        /// <summary>
        /// Running flag
        /// </summary>
        private bool isRunning = false;

        /// <summary>
        /// The main status strip.
        /// </summary>
        private StatusStrip mainStatusStrip;

        /// <summary>
        /// The status tool strip status label.
        /// </summary>
        private ToolStripStatusLabel statusToolStripStatusLabel;

        /// <summary>
        /// The run button.
        /// </summary>
        private Button runButton;

        /// <summary>
        /// The undo button.
        /// </summary>
        private Button undoButton;

        /// <summary>
        /// The separator label.
        /// </summary>
        private Label separatorLabel;

        /// <summary>
        /// The step button.
        /// </summary>
        private Button stepButton;

        /// <summary>
        /// The browse button.
        /// </summary>
        private Button browseButton;

        /// <summary>
        /// The main open file dialog.
        /// </summary>
        private OpenFileDialog mainOpenFileDialog = new OpenFileDialog();

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="File__Input___40_in_45_memory_43_GUI_41_.File__Input___40_in_45_memory_43_GUI_41_"/> class.
        /// </summary>
        public File__Input___40_in_45_memory_43_GUI_41_()
        {
            // Initialization
            this.browseButton = new Button();
            this.stepButton = new Button();
            this.undoButton = new Button();
            this.separatorLabel = new Label();
            this.runButton = new Button();
            this.mainStatusStrip = new StatusStrip();
            this.statusToolStripStatusLabel = new ToolStripStatusLabel();
            this.mainStatusStrip.SuspendLayout();
            this.SuspendLayout();

            // browseButton
            this.browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.browseButton.Location = new System.Drawing.Point(12, 12);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(178, 25);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "&Browse for file";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.BrowseButton_Click);

            // stepButton
            this.stepButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.stepButton.Location = new System.Drawing.Point(12, 59);
            this.stepButton.Name = "stepButton";
            this.stepButton.Size = new System.Drawing.Size(178, 50);
            this.stepButton.TabIndex = 1;
            this.stepButton.Text = "&STEP";
            this.stepButton.UseVisualStyleBackColor = true;
            this.stepButton.Click += new System.EventHandler(this.StepButton_Click);

            // undoButton
            this.undoButton.Location = new System.Drawing.Point(12, 115);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(178, 25);
            this.undoButton.TabIndex = 2;
            this.undoButton.Text = "&UNDO";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.UndoButton_Click);

            // separatorLabel
            this.separatorLabel.Location = new System.Drawing.Point(12, 30);
            this.separatorLabel.Name = "separatorLabel";
            this.separatorLabel.Size = new System.Drawing.Size(178, 23);
            this.separatorLabel.TabIndex = 2;
            this.separatorLabel.Text = "________________________";
            this.separatorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // runButton
            this.runButton.Location = new System.Drawing.Point(107, 115);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(83, 25);
            this.runButton.TabIndex = 3;
            this.runButton.Text = "&Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.RunButton_Click);

            // mainStatusStrip
            this.mainStatusStrip.Items.AddRange(new ToolStripItem[]
                {
                    this.statusToolStripStatusLabel
                });
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 150);
            this.mainStatusStrip.Name = "ss";
            this.mainStatusStrip.Size = new System.Drawing.Size(202, 22);
            this.mainStatusStrip.TabIndex = 3;

            // statusToolStripStatusLabel
            this.statusToolStripStatusLabel.Name = "tsslStatus";
            this.statusToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);

            // FileInputInMemory
            this.ClientSize = new System.Drawing.Size(202, 172);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.stepButton);
            /*this.Controls.Add(this.bRun);*/
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.separatorLabel);
            this.Name = "FileInputInMemoryGUI";
            this.Text = "File Input (in-memory+GUI)";
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            // mainOpenFileDialog
            this.mainOpenFileDialog.InitialDirectory = Application.StartupPath;
            this.mainOpenFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            this.mainOpenFileDialog.RestoreDirectory = true;
        }

        /// <summary>
        /// Initializes module.
        /// </summary>
        /// <param name="passedMarshal">Passed marshal.</param>
        public void Init(object passedMarshal)
        {
            // Set marshal 
            this.marshal = passedMarshal;

            // Set icon
            this.Icon = (Icon)this.marshal.GetType().GetProperty("Icon").GetValue(this.marshal, null);

            // Show form
            this.Show();
        }

        /// <summary>
        /// Browse button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void BrowseButton_Click(object sender, EventArgs e)
        {
            // Open file dialog
            if (this.mainOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    /* Read file to memory */

                    // Reset pointer
                    this.pointer = 0;

                    // Reset lines list
                    this.lines.Clear();

                    // Make use of StreamReader
                    using (StreamReader sr = new StreamReader(this.mainOpenFileDialog.FileName))
                    {
                        // Current line
                        string line;

                        // Iterate through lines
                        while ((line = sr.ReadLine()) != null)
                        {
                            // Add current line
                            this.lines.Add(line);
                        }
                    }

                    // Update status
                    this.statusToolStripStatusLabel.Text = "Read: " + this.lines.Count + " lines";
                }
                catch (Exception ex)
                {
                    // Error message
                        MessageBox.Show("Error: Could not read file from disk." + Environment.NewLine + "Error message: " + ex.Message, "File read error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Step button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void StepButton_Click(object sender, EventArgs e)
        {
            // Check there's something to work with and pointer is within range
            if (this.lines.Count < 1 || this.pointer > (this.lines.Count - 1))
            {
                // Exit
                return;
            }

            // Send current input
            this.marshal.GetType().InvokeMember("Input", BindingFlags.InvokeMethod, null, this.marshal, new object[] { this.lines[this.pointer] });

            // Rise list pointer
            this.pointer++;
        }

        /// <summary>
        /// Undo button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void UndoButton_Click(object sender, EventArgs e)
        {
            // Send "undo" message
            this.marshal.GetType().InvokeMember("Input", BindingFlags.InvokeMethod, null, this.marshal, new object[] { "-U" });

            // Check list pointer is in use
            if (this.pointer > 0)
            {
                // Decrement list pointer
                this.pointer--;
            }
        }

        /// <summary>
        /// Run button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void RunButton_Click(object sender, EventArgs e)
        {
            // Check
            if (!this.isRunning)
            {
                // Change button caption
                this.runButton.Text = "S&top";

                // Set flag
                this.isRunning = true;

                // TODO Start run code
            }
            else
            {
                // Change button caption
                this.runButton.Text = "&Run";

                // Set flag
                this.isRunning = false;

                // TODO Stop run code
            }
        }

        /*/// <summary>
        /// Run method (stub)
        /// </summary>
        private void Run()
        {
            // Check if there are lines left

            // Press step indefinitely
            while (pointer < (lines.Count - 1))
            {
                // Press step
                stepButton.PerformClick();
            }
        }*/
    }
}