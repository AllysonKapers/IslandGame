namespace IslandGame
{
    partial class IslandGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IslandGame));
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.GameMap = new System.Windows.Forms.Label();
            this.RowLabel = new System.Windows.Forms.Label();
            this.ColumnLabel = new System.Windows.Forms.Label();
            this.RowTxtBox = new System.Windows.Forms.TextBox();
            this.ColumnTxtBox = new System.Windows.Forms.TextBox();
            this.GamePlayBox = new System.Windows.Forms.GroupBox();
            this.GuessButton = new System.Windows.Forms.Button();
            this.MapBox = new System.Windows.Forms.GroupBox();
            this.WinLabel = new System.Windows.Forms.Label();
            this.MenuBox = new System.Windows.Forms.GroupBox();
            this.CLoseButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.SetRowLabel = new System.Windows.Forms.Label();
            this.SetColumnLabel = new System.Windows.Forms.Label();
            this.SetRowTxtBox = new System.Windows.Forms.TextBox();
            this.SetColumnTxtBox = new System.Windows.Forms.TextBox();
            this.SetMapBox = new System.Windows.Forms.GroupBox();
            this.SetButton = new System.Windows.Forms.Button();
            this.InstructionBox = new System.Windows.Forms.GroupBox();
            this.GamePlayBox.SuspendLayout();
            this.MapBox.SuspendLayout();
            this.MenuBox.SuspendLayout();
            this.SetMapBox.SuspendLayout();
            this.InstructionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.AutoSize = true;
            this.InstructionsLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InstructionsLabel.Location = new System.Drawing.Point(12, 26);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(766, 352);
            this.InstructionsLabel.TabIndex = 2;
            this.InstructionsLabel.Text ="Instructions: \r\n" +
                                         "Welcome to the Island Game. \r\n" +
                                         "The goal is to guess the location of the island\r\n" + 
                                         "To start a game: click start\r\n" + 
                                         "To edit the size of the map: click settings, then enter \r\n" + 
                                         "      dimensions and click set\r\n" + 
                                         "To submit a guess: enter a row and column number in the text boxes\r\n"+ 
                                         "      and press guess\r\n" + 
                                         "The map will update with cardinal directions directing you to the island.\r\n" + 
                                         "If your guess is in the same row/column as the island, a C or R will appear.";

            // 
            // GameMap
            // 
            this.GameMap.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GameMap.Location = new System.Drawing.Point(20, 22);
            this.GameMap.Name = "GameMap";
            this.GameMap.Size = new System.Drawing.Size(400, 400);
            this.GameMap.TabIndex = 0;
            // 
            // RowLabel
            // 
            this.RowLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RowLabel.Location = new System.Drawing.Point(42, 44);
            this.RowLabel.Name = "RowLabel";
            this.RowLabel.Size = new System.Drawing.Size(130, 22);
            this.RowLabel.TabIndex = 6;
            this.RowLabel.Text = "Row Guess:";
            // 
            // ColumnLabel
            // 
            this.ColumnLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ColumnLabel.Location = new System.Drawing.Point(6, 85);
            this.ColumnLabel.Name = "ColumnLabel";
            this.ColumnLabel.Size = new System.Drawing.Size(166, 22);
            this.ColumnLabel.TabIndex = 7;
            this.ColumnLabel.Text = "Column Guess:";
            // 
            // RowTxtBox
            // 
            this.RowTxtBox.Location = new System.Drawing.Point(168, 31);
            this.RowTxtBox.Name = "RowTxtBox";
            this.RowTxtBox.Size = new System.Drawing.Size(100, 35);
            this.RowTxtBox.TabIndex = 9;
            this.RowTxtBox.TextChanged += new System.EventHandler(this.RowTxtBox_TextChanged);
            // 
            // ColumnTxtBox
            // 
            this.ColumnTxtBox.Location = new System.Drawing.Point(168, 72);
            this.ColumnTxtBox.Name = "ColumnTxtBox";
            this.ColumnTxtBox.Size = new System.Drawing.Size(100, 35);
            this.ColumnTxtBox.TabIndex = 10;
            this.ColumnTxtBox.TextChanged += new System.EventHandler(this.ColumnTxtBox_TextChanged);
            // 
            // GamePlayBox
            // 
            this.GamePlayBox.Controls.Add(this.GuessButton);
            this.GamePlayBox.Controls.Add(this.RowTxtBox);
            this.GamePlayBox.Controls.Add(this.ColumnLabel);
            this.GamePlayBox.Controls.Add(this.RowLabel);
            this.GamePlayBox.Controls.Add(this.ColumnTxtBox);
            this.GamePlayBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GamePlayBox.Location = new System.Drawing.Point(48, 436);
            this.GamePlayBox.Name = "GamePlayBox";
            this.GamePlayBox.Size = new System.Drawing.Size(293, 187);
            this.GamePlayBox.TabIndex = 1;
            this.GamePlayBox.TabStop = false;
            this.GamePlayBox.Text = "Controls:";
            // 
            // GuessButton
            // 
            this.GuessButton.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GuessButton.Location = new System.Drawing.Point(69, 128);
            this.GuessButton.Name = "GuessButton";
            this.GuessButton.Size = new System.Drawing.Size(138, 34);
            this.GuessButton.TabIndex = 11;
            this.GuessButton.Text = "Guess";
            this.GuessButton.UseVisualStyleBackColor = true;
            this.GuessButton.Click += new System.EventHandler(this.GuessButton_Click);
            // 
            // MapBox
            // 
            this.MapBox.Controls.Add(this.GameMap);
            this.MapBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MapBox.Location = new System.Drawing.Point(360, 407);
            this.MapBox.Name = "MapBox";
            this.MapBox.Size = new System.Drawing.Size(435, 429);
            this.MapBox.TabIndex = 4;
            this.MapBox.TabStop = false;
            this.MapBox.Text = "Map:";
            // 
            // WinLabel
            // 
            this.WinLabel.Font = new System.Drawing.Font("Courier New", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WinLabel.Location = new System.Drawing.Point(106, 459);
            this.WinLabel.Name = "WinLabel";
            this.WinLabel.Size = new System.Drawing.Size(686, 168);
            this.WinLabel.TabIndex = 11;
            this.WinLabel.Text = "Congrats! You found the island!";
            // 
            // MenuBox
            // 
            this.MenuBox.Controls.Add(this.CLoseButton);
            this.MenuBox.Controls.Add(this.SettingsButton);
            this.MenuBox.Controls.Add(this.StartButton);
            this.MenuBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuBox.Location = new System.Drawing.Point(822, 652);
            this.MenuBox.Name = "MenuBox";
            this.MenuBox.Size = new System.Drawing.Size(150, 185);
            this.MenuBox.TabIndex = 5;
            this.MenuBox.TabStop = false;
            this.MenuBox.Text = "Menu:";
            // 
            // CLoseButton
            // 
            this.CLoseButton.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CLoseButton.Location = new System.Drawing.Point(6, 132);
            this.CLoseButton.Name = "CLoseButton";
            this.CLoseButton.Size = new System.Drawing.Size(138, 34);
            this.CLoseButton.TabIndex = 2;
            this.CLoseButton.Text = "Close";
            this.CLoseButton.UseVisualStyleBackColor = true;
            this.CLoseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SettingsButton.Location = new System.Drawing.Point(6, 83);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(138, 34);
            this.SettingsButton.TabIndex = 1;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartButton.Location = new System.Drawing.Point(6, 34);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(138, 34);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // SetRowLabel
            // 
            this.SetRowLabel.AutoSize = true;
            this.SetRowLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SetRowLabel.Location = new System.Drawing.Point(48, 48);
            this.SetRowLabel.Name = "SetRowLabel";
            this.SetRowLabel.Size = new System.Drawing.Size(154, 22);
            this.SetRowLabel.TabIndex = 6;
            this.SetRowLabel.Text = "Set Map Row:";
            // 
            // SetColumnLabel
            // 
            this.SetColumnLabel.AutoSize = true;
            this.SetColumnLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SetColumnLabel.Location = new System.Drawing.Point(12, 85);
            this.SetColumnLabel.Name = "SetColumnLabel";
            this.SetColumnLabel.Size = new System.Drawing.Size(190, 22);
            this.SetColumnLabel.TabIndex = 7;
            this.SetColumnLabel.Text = "Set Map Column:";
            // 
            // SetRowTxtBox
            // 
            this.SetRowTxtBox.Location = new System.Drawing.Point(204, 40);
            this.SetRowTxtBox.Name = "SetRowTxtBox";
            this.SetRowTxtBox.Size = new System.Drawing.Size(150, 30);
            this.SetRowTxtBox.TabIndex = 8;
            //this.SetRowTxtBox.TextChanged += new System.EventHandler(this.SetRowTxtBox_TextChanged);
            // 
            // SetColumnTxtBox
            // 
            this.SetColumnTxtBox.Location = new System.Drawing.Point(204, 77);
            this.SetColumnTxtBox.Name = "SetColumnTxtBox";
            this.SetColumnTxtBox.Size = new System.Drawing.Size(150, 30);
            this.SetColumnTxtBox.TabIndex = 9;
            this.SetColumnTxtBox.TextChanged += new System.EventHandler(this.SetColumnTxtBox_TextChanged);
            // 
            // SetMapBox
            // 
            this.SetMapBox.Controls.Add(this.SetButton);
            this.SetMapBox.Controls.Add(this.SetRowLabel);
            this.SetMapBox.Controls.Add(this.SetRowTxtBox);
            this.SetMapBox.Controls.Add(this.SetColumnTxtBox);
            this.SetMapBox.Controls.Add(this.SetColumnLabel);
            this.SetMapBox.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SetMapBox.Location = new System.Drawing.Point(0, 652);
            this.SetMapBox.Name = "SetMapBox";
            this.SetMapBox.Size = new System.Drawing.Size(374, 184);
            this.SetMapBox.TabIndex = 10;
            this.SetMapBox.TabStop = false;
            this.SetMapBox.Text = "Map Dimensions:";
            // 
            // SetButton
            // 
            this.SetButton.Location = new System.Drawing.Point(118, 130);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(112, 34);
            this.SetButton.TabIndex = 10;
            this.SetButton.Text = "Set";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // InstructionBox
            // 
            this.InstructionBox.Controls.Add(this.InstructionsLabel);
            this.InstructionBox.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InstructionBox.Location = new System.Drawing.Point(0, 0);
            this.InstructionBox.Name = "InstructionBox";
            this.InstructionBox.Size = new System.Drawing.Size(872, 401);
            this.InstructionBox.TabIndex = 11;
            this.InstructionBox.TabStop = false;
            this.InstructionBox.Text = "Description:";
            // 
            // IslandGame
            // 
            this.ClientSize = new System.Drawing.Size(975, 838);
            this.Controls.Add(this.MenuBox);
            this.Controls.Add(this.GamePlayBox);
            this.Controls.Add(this.MapBox);
            this.Controls.Add(this.SetMapBox);
            this.Controls.Add(this.InstructionBox);
            this.Name = "IslandGame";
            this.Text = "Island Game";
            this.GamePlayBox.ResumeLayout(false);
            this.GamePlayBox.PerformLayout();
            this.MapBox.ResumeLayout(false);
            this.MenuBox.ResumeLayout(false);
            this.SetMapBox.ResumeLayout(false);
            this.SetMapBox.PerformLayout();
            this.InstructionBox.ResumeLayout(false);
            this.InstructionBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


        private Label InstructionsLabel;
        private Label GameMap;
        private Label RowLabel;
        private Label ColumnLabel;
        private Label SetRowLabel;
        private Label SetColumnLabel;
        private Label WinLabel;

        private TextBox RowTxtBox;
        private TextBox ColumnTxtBox;
        private TextBox SetRowTxtBox;
        private TextBox SetColumnTxtBox;




        private Button CLoseButton;
        private Button SettingsButton;
        private Button StartButton;
        private Button GuessButton;


        private GroupBox SetMapBox;
        private GroupBox InstructionBox;
        private GroupBox GamePlayBox;
        private GroupBox MapBox;
        private GroupBox MenuBox;
        private Button SetButton;
    }
}