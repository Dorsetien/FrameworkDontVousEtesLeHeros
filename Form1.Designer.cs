using System.Drawing;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panelActionTexte = new System.Windows.Forms.Panel();
            this.groupBoxChoix = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pictureBox_Heros = new System.Windows.Forms.PictureBox();
            this.pictureBox_Ennemi = new System.Windows.Forms.PictureBox();
            this.labelHabilete_Heros = new System.Windows.Forms.Label();
            this.labelPDVHeros = new System.Windows.Forms.Label();
            this.labelPDVEnemmi = new System.Windows.Forms.Label();
            this.labelHabileteEnnemi = new System.Windows.Forms.Label();
            this.textBoxHabileteHeros = new System.Windows.Forms.TextBox();
            this.textBoxPDVHeros = new System.Windows.Forms.TextBox();
            this.textBoxHabileteEnnemi = new System.Windows.Forms.TextBox();
            this.textBoxPDVEnnemi = new System.Windows.Forms.TextBox();
            this.pictureBoxDe1Heros = new System.Windows.Forms.PictureBox();
            this.pictureBoxDe2Heros = new System.Windows.Forms.PictureBox();
            this.pictureBoxDe1Ennemi = new System.Windows.Forms.PictureBox();
            this.pictureBoxDe2Ennemi = new System.Windows.Forms.PictureBox();
            this.labelNomHero = new System.Windows.Forms.Label();
            this.labelNomEnnemi = new System.Windows.Forms.Label();
            this.labelEquipement = new System.Windows.Forms.Label();
            this.panelHerosEnnemi = new System.Windows.Forms.Panel();
            this.listViewEquipement = new System.Windows.Forms.ListView();
            this.Équipement = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ModifHabilete = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ModifPDV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ModifChance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxChanceHeros = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Total_Des_Heros = new System.Windows.Forms.TextBox();
            this.label_vs = new System.Windows.Forms.Label();
            this.textBox_Total_Des_Ennemi = new System.Windows.Forms.TextBox();
            this.panelActionTexte.SuspendLayout();
            this.groupBoxChoix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Heros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ennemi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDe1Heros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDe2Heros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDe1Ennemi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDe2Ennemi)).BeginInit();
            this.panelHerosEnnemi.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.richTextBox1.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(154, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(364, 729);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // panelActionTexte
            // 
            this.panelActionTexte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelActionTexte.Controls.Add(this.groupBoxChoix);
            this.panelActionTexte.Controls.Add(this.richTextBox1);
            this.panelActionTexte.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelActionTexte.Location = new System.Drawing.Point(490, 0);
            this.panelActionTexte.Name = "panelActionTexte";
            this.panelActionTexte.Size = new System.Drawing.Size(518, 729);
            this.panelActionTexte.TabIndex = 4;
            // 
            // groupBoxChoix
            // 
            this.groupBoxChoix.Controls.Add(this.radioButton5);
            this.groupBoxChoix.Controls.Add(this.button1);
            this.groupBoxChoix.Controls.Add(this.radioButton4);
            this.groupBoxChoix.Controls.Add(this.radioButton3);
            this.groupBoxChoix.Controls.Add(this.radioButton2);
            this.groupBoxChoix.Controls.Add(this.radioButton1);
            this.groupBoxChoix.Location = new System.Drawing.Point(3, 28);
            this.groupBoxChoix.Name = "groupBoxChoix";
            this.groupBoxChoix.Size = new System.Drawing.Size(145, 205);
            this.groupBoxChoix.TabIndex = 8;
            this.groupBoxChoix.TabStop = false;
            this.groupBoxChoix.Text = "Choix";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Italic);
            this.radioButton5.Location = new System.Drawing.Point(6, 128);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(74, 22);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Choix5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Italic);
            this.button1.Location = new System.Drawing.Point(0, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Action";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Italic);
            this.radioButton4.Location = new System.Drawing.Point(6, 105);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(74, 22);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Choix4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Italic);
            this.radioButton3.Location = new System.Drawing.Point(6, 82);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(74, 22);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Choix3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Italic);
            this.radioButton2.Location = new System.Drawing.Point(7, 59);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 22);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Choix2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Italic);
            this.radioButton1.Location = new System.Drawing.Point(6, 36);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(74, 22);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Choix1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox_Heros
            // 
            this.pictureBox_Heros.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Heros.Location = new System.Drawing.Point(12, 31);
            this.pictureBox_Heros.Name = "pictureBox_Heros";
            this.pictureBox_Heros.Size = new System.Drawing.Size(192, 296);
            this.pictureBox_Heros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Heros.TabIndex = 5;
            this.pictureBox_Heros.TabStop = false;
            // 
            // pictureBox_Ennemi
            // 
            this.pictureBox_Ennemi.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Ennemi.Location = new System.Drawing.Point(292, 31);
            this.pictureBox_Ennemi.Name = "pictureBox_Ennemi";
            this.pictureBox_Ennemi.Size = new System.Drawing.Size(192, 296);
            this.pictureBox_Ennemi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Ennemi.TabIndex = 6;
            this.pictureBox_Ennemi.TabStop = false;
            // 
            // labelHabilete_Heros
            // 
            this.labelHabilete_Heros.AutoSize = true;
            this.labelHabilete_Heros.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Italic);
            this.labelHabilete_Heros.Location = new System.Drawing.Point(12, 371);
            this.labelHabilete_Heros.Name = "labelHabilete_Heros";
            this.labelHabilete_Heros.Size = new System.Drawing.Size(69, 18);
            this.labelHabilete_Heros.TabIndex = 8;
            this.labelHabilete_Heros.Text = "Habileté:";
            // 
            // labelPDVHeros
            // 
            this.labelPDVHeros.AutoSize = true;
            this.labelPDVHeros.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Italic);
            this.labelPDVHeros.Location = new System.Drawing.Point(12, 394);
            this.labelPDVHeros.Name = "labelPDVHeros";
            this.labelPDVHeros.Size = new System.Drawing.Size(100, 18);
            this.labelPDVHeros.TabIndex = 9;
            this.labelPDVHeros.Text = "Points de vie:";
            // 
            // labelPDVEnemmi
            // 
            this.labelPDVEnemmi.AutoSize = true;
            this.labelPDVEnemmi.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Italic);
            this.labelPDVEnemmi.Location = new System.Drawing.Point(332, 389);
            this.labelPDVEnemmi.Name = "labelPDVEnemmi";
            this.labelPDVEnemmi.Size = new System.Drawing.Size(100, 18);
            this.labelPDVEnemmi.TabIndex = 11;
            this.labelPDVEnemmi.Text = "Points de vie:";
            // 
            // labelHabileteEnnemi
            // 
            this.labelHabileteEnnemi.AutoSize = true;
            this.labelHabileteEnnemi.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Italic);
            this.labelHabileteEnnemi.Location = new System.Drawing.Point(363, 369);
            this.labelHabileteEnnemi.Name = "labelHabileteEnnemi";
            this.labelHabileteEnnemi.Size = new System.Drawing.Size(69, 18);
            this.labelHabileteEnnemi.TabIndex = 10;
            this.labelHabileteEnnemi.Text = "Habileté:";
            // 
            // textBoxHabileteHeros
            // 
            this.textBoxHabileteHeros.Location = new System.Drawing.Point(119, 369);
            this.textBoxHabileteHeros.Name = "textBoxHabileteHeros";
            this.textBoxHabileteHeros.Size = new System.Drawing.Size(46, 20);
            this.textBoxHabileteHeros.TabIndex = 12;
            // 
            // textBoxPDVHeros
            // 
            this.textBoxPDVHeros.Location = new System.Drawing.Point(119, 392);
            this.textBoxPDVHeros.Name = "textBoxPDVHeros";
            this.textBoxPDVHeros.Size = new System.Drawing.Size(46, 20);
            this.textBoxPDVHeros.TabIndex = 13;
            // 
            // textBoxHabileteEnnemi
            // 
            this.textBoxHabileteEnnemi.Location = new System.Drawing.Point(438, 367);
            this.textBoxHabileteEnnemi.Name = "textBoxHabileteEnnemi";
            this.textBoxHabileteEnnemi.Size = new System.Drawing.Size(46, 20);
            this.textBoxHabileteEnnemi.TabIndex = 14;
            // 
            // textBoxPDVEnnemi
            // 
            this.textBoxPDVEnnemi.Location = new System.Drawing.Point(438, 390);
            this.textBoxPDVEnnemi.Name = "textBoxPDVEnnemi";
            this.textBoxPDVEnnemi.Size = new System.Drawing.Size(46, 20);
            this.textBoxPDVEnnemi.TabIndex = 15;
            // 
            // pictureBoxDe1Heros
            // 
            this.pictureBoxDe1Heros.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDe1Heros.Location = new System.Drawing.Point(12, 331);
            this.pictureBoxDe1Heros.Name = "pictureBoxDe1Heros";
            this.pictureBoxDe1Heros.Size = new System.Drawing.Size(33, 37);
            this.pictureBoxDe1Heros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDe1Heros.TabIndex = 16;
            this.pictureBoxDe1Heros.TabStop = false;
            // 
            // pictureBoxDe2Heros
            // 
            this.pictureBoxDe2Heros.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDe2Heros.Location = new System.Drawing.Point(51, 331);
            this.pictureBoxDe2Heros.Name = "pictureBoxDe2Heros";
            this.pictureBoxDe2Heros.Size = new System.Drawing.Size(33, 37);
            this.pictureBoxDe2Heros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDe2Heros.TabIndex = 17;
            this.pictureBoxDe2Heros.TabStop = false;
            // 
            // pictureBoxDe1Ennemi
            // 
            this.pictureBoxDe1Ennemi.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDe1Ennemi.Location = new System.Drawing.Point(412, 329);
            this.pictureBoxDe1Ennemi.Name = "pictureBoxDe1Ennemi";
            this.pictureBoxDe1Ennemi.Size = new System.Drawing.Size(33, 37);
            this.pictureBoxDe1Ennemi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDe1Ennemi.TabIndex = 18;
            this.pictureBoxDe1Ennemi.TabStop = false;
            // 
            // pictureBoxDe2Ennemi
            // 
            this.pictureBoxDe2Ennemi.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDe2Ennemi.Location = new System.Drawing.Point(451, 329);
            this.pictureBoxDe2Ennemi.Name = "pictureBoxDe2Ennemi";
            this.pictureBoxDe2Ennemi.Size = new System.Drawing.Size(33, 37);
            this.pictureBoxDe2Ennemi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDe2Ennemi.TabIndex = 19;
            this.pictureBoxDe2Ennemi.TabStop = false;
            // 
            // labelNomHero
            // 
            this.labelNomHero.AutoSize = true;
            this.labelNomHero.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Italic);
            this.labelNomHero.Location = new System.Drawing.Point(13, 8);
            this.labelNomHero.Name = "labelNomHero";
            this.labelNomHero.Size = new System.Drawing.Size(50, 18);
            this.labelNomHero.TabIndex = 20;
            this.labelNomHero.Text = "Héros";
            // 
            // labelNomEnnemi
            // 
            this.labelNomEnnemi.AutoSize = true;
            this.labelNomEnnemi.Font = new System.Drawing.Font("Lucida Bright", 10.25F, System.Drawing.FontStyle.Italic);
            this.labelNomEnnemi.Location = new System.Drawing.Point(255, 8);
            this.labelNomEnnemi.Name = "labelNomEnnemi";
            this.labelNomEnnemi.Size = new System.Drawing.Size(229, 16);
            this.labelNomEnnemi.TabIndex = 21;
            this.labelNomEnnemi.Text = "Illustrations, Rencontres, Ennemis";
            // 
            // labelEquipement
            // 
            this.labelEquipement.AutoSize = true;
            this.labelEquipement.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Italic);
            this.labelEquipement.Location = new System.Drawing.Point(9, 462);
            this.labelEquipement.Name = "labelEquipement";
            this.labelEquipement.Size = new System.Drawing.Size(90, 18);
            this.labelEquipement.TabIndex = 23;
            this.labelEquipement.Text = "Équipement";
            // 
            // panelHerosEnnemi
            // 
            this.panelHerosEnnemi.AutoScroll = true;
            this.panelHerosEnnemi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelHerosEnnemi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelHerosEnnemi.Controls.Add(this.textBox_Total_Des_Ennemi);
            this.panelHerosEnnemi.Controls.Add(this.label_vs);
            this.panelHerosEnnemi.Controls.Add(this.textBox_Total_Des_Heros);
            this.panelHerosEnnemi.Controls.Add(this.listViewEquipement);
            this.panelHerosEnnemi.Controls.Add(this.textBoxChanceHeros);
            this.panelHerosEnnemi.Controls.Add(this.label2);
            this.panelHerosEnnemi.Controls.Add(this.textBoxOr);
            this.panelHerosEnnemi.Controls.Add(this.label1);
            this.panelHerosEnnemi.Controls.Add(this.labelEquipement);
            this.panelHerosEnnemi.Controls.Add(this.pictureBox_Heros);
            this.panelHerosEnnemi.Controls.Add(this.pictureBox_Ennemi);
            this.panelHerosEnnemi.Controls.Add(this.labelNomEnnemi);
            this.panelHerosEnnemi.Controls.Add(this.labelHabilete_Heros);
            this.panelHerosEnnemi.Controls.Add(this.labelNomHero);
            this.panelHerosEnnemi.Controls.Add(this.labelPDVHeros);
            this.panelHerosEnnemi.Controls.Add(this.pictureBoxDe2Ennemi);
            this.panelHerosEnnemi.Controls.Add(this.labelHabileteEnnemi);
            this.panelHerosEnnemi.Controls.Add(this.pictureBoxDe1Ennemi);
            this.panelHerosEnnemi.Controls.Add(this.labelPDVEnemmi);
            this.panelHerosEnnemi.Controls.Add(this.pictureBoxDe2Heros);
            this.panelHerosEnnemi.Controls.Add(this.textBoxHabileteHeros);
            this.panelHerosEnnemi.Controls.Add(this.pictureBoxDe1Heros);
            this.panelHerosEnnemi.Controls.Add(this.textBoxPDVHeros);
            this.panelHerosEnnemi.Controls.Add(this.textBoxPDVEnnemi);
            this.panelHerosEnnemi.Controls.Add(this.textBoxHabileteEnnemi);
            this.panelHerosEnnemi.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelHerosEnnemi.Location = new System.Drawing.Point(0, 0);
            this.panelHerosEnnemi.Name = "panelHerosEnnemi";
            this.panelHerosEnnemi.Size = new System.Drawing.Size(1533, 729);
            this.panelHerosEnnemi.TabIndex = 24;
            // 
            // listViewEquipement
            // 
            this.listViewEquipement.BackColor = System.Drawing.SystemColors.Control;
            this.listViewEquipement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewEquipement.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Équipement,
            this.ModifHabilete,
            this.ModifPDV,
            this.ModifChance});
            this.listViewEquipement.Font = new System.Drawing.Font("Lucida Bright", 8F, System.Drawing.FontStyle.Italic);
            this.listViewEquipement.FullRowSelect = true;
            this.listViewEquipement.GridLines = true;
            this.listViewEquipement.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewEquipement.HideSelection = false;
            this.listViewEquipement.Location = new System.Drawing.Point(11, 483);
            this.listViewEquipement.MultiSelect = false;
            this.listViewEquipement.Name = "listViewEquipement";
            this.listViewEquipement.Size = new System.Drawing.Size(289, 167);
            this.listViewEquipement.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewEquipement.TabIndex = 29;
            this.listViewEquipement.UseCompatibleStateImageBehavior = false;
            this.listViewEquipement.View = System.Windows.Forms.View.Details;
            // 
            // Équipement
            // 
            this.Équipement.Text = "Équipement";
            this.Équipement.Width = 75;
            // 
            // ModifHabilete
            // 
            this.ModifHabilete.Text = "+/-Habileté";
            this.ModifHabilete.Width = 75;
            // 
            // ModifPDV
            // 
            this.ModifPDV.Text = "+/-PDV";
            // 
            // ModifChance
            // 
            this.ModifChance.Text = "+/-Chance";
            this.ModifChance.Width = 76;
            // 
            // textBoxChanceHeros
            // 
            this.textBoxChanceHeros.Location = new System.Drawing.Point(119, 416);
            this.textBoxChanceHeros.Name = "textBoxChanceHeros";
            this.textBoxChanceHeros.Size = new System.Drawing.Size(46, 20);
            this.textBoxChanceHeros.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(13, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Chance :";
            // 
            // textBoxOr
            // 
            this.textBoxOr.Location = new System.Drawing.Point(119, 441);
            this.textBoxOr.Name = "textBoxOr";
            this.textBoxOr.Size = new System.Drawing.Size(46, 20);
            this.textBoxOr.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(12, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Or:";
            // 
            // textBox_Total_Des_Heros
            // 
            this.textBox_Total_Des_Heros.Location = new System.Drawing.Point(205, 346);
            this.textBox_Total_Des_Heros.Name = "textBox_Total_Des_Heros";
            this.textBox_Total_Des_Heros.Size = new System.Drawing.Size(24, 20);
            this.textBox_Total_Des_Heros.TabIndex = 30;
            // 
            // label_vs
            // 
            this.label_vs.AutoSize = true;
            this.label_vs.Location = new System.Drawing.Point(235, 349);
            this.label_vs.Name = "label_vs";
            this.label_vs.Size = new System.Drawing.Size(18, 13);
            this.label_vs.TabIndex = 31;
            this.label_vs.Text = "vs";
            // 
            // textBox_Total_Des_Ennemi
            // 
            this.textBox_Total_Des_Ennemi.Location = new System.Drawing.Point(259, 346);
            this.textBox_Total_Des_Ennemi.Name = "textBox_Total_Des_Ennemi";
            this.textBox_Total_Des_Ennemi.Size = new System.Drawing.Size(24, 20);
            this.textBox_Total_Des_Ennemi.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panelActionTexte);
            this.Controls.Add(this.panelHerosEnnemi);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "Form1";
            this.Text = "Framework Dont Vous Êtes Le Héros";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelActionTexte.ResumeLayout(false);
            this.groupBoxChoix.ResumeLayout(false);
            this.groupBoxChoix.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Heros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ennemi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDe1Heros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDe2Heros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDe1Ennemi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDe2Ennemi)).EndInit();
            this.panelHerosEnnemi.ResumeLayout(false);
            this.panelHerosEnnemi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panelActionTexte;
        private System.Windows.Forms.PictureBox pictureBox_Heros;
        private System.Windows.Forms.PictureBox pictureBox_Ennemi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelHabilete_Heros;
        private System.Windows.Forms.Label labelPDVHeros;
        private System.Windows.Forms.Label labelPDVEnemmi;
        private System.Windows.Forms.Label labelHabileteEnnemi;
        private System.Windows.Forms.TextBox textBoxHabileteHeros;
        private System.Windows.Forms.TextBox textBoxPDVHeros;
        private System.Windows.Forms.TextBox textBoxHabileteEnnemi;
        private System.Windows.Forms.TextBox textBoxPDVEnnemi;
        private System.Windows.Forms.PictureBox pictureBoxDe1Heros;
        private System.Windows.Forms.PictureBox pictureBoxDe2Heros;
        private System.Windows.Forms.PictureBox pictureBoxDe1Ennemi;
        private System.Windows.Forms.PictureBox pictureBoxDe2Ennemi;
        private System.Windows.Forms.Label labelNomHero;
        private System.Windows.Forms.Label labelNomEnnemi;
        private System.Windows.Forms.Label labelEquipement;
        private System.Windows.Forms.Panel panelHerosEnnemi;
        private System.Windows.Forms.GroupBox groupBoxChoix;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBoxOr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxChanceHeros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewEquipement;
        private System.Windows.Forms.ColumnHeader Équipement;
        private System.Windows.Forms.ColumnHeader ModifHabilete;
        private System.Windows.Forms.ColumnHeader ModifPDV;
        private System.Windows.Forms.ColumnHeader ModifChance;
        private System.Windows.Forms.TextBox textBox_Total_Des_Ennemi;
        private System.Windows.Forms.Label label_vs;
        private System.Windows.Forms.TextBox textBox_Total_Des_Heros;
    }
}

