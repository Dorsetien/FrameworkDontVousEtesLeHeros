/* code par SD 2020 */

using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Media;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string numeroParagraphe = "000";
        public int intHabileteHeros = 0;
        public int intPDVHeros = 0;
        public int intDesDebutHabPDVChance = 0;
        public int etatCombat = 0;
        public int intPDVEnnemi = 0;
        public int intHabileteEnnemi = 0;
        public string etatParagrapheAvantCombat;
        public int intOr = 0;
        public int intChanceHeros = 0;

        public void Form1_Load(object sender, EventArgs e)
        {
            Initialisation_Debut();
        }

        /***********************************************************************************************************/
        /******************************************  INITIALISATION DU JEU   ***************************************/
        /***********************************************************************************************************/
        public void Initialisation_Debut()
        {
            pictureBox_Heros.Visible = false;
            pictureBox_Ennemi.Visible = false;
            pictureBox_Ennemi.Image = null;
            pictureBox_Heros.Image = null;
            numeroParagraphe = "000";
            intHabileteHeros = 0;
            intPDVHeros = 0;
            intDesDebutHabPDVChance = 0;
            etatCombat = 0;
            intPDVEnnemi = 0;
            intHabileteEnnemi = 0;
            intChanceHeros = 0;
            textBox_Total_Des_Heros.Text = "0";
            textBox_Total_Des_Ennemi.Text = "0";
            textBox_Total_Des_Heros.Visible = false;
            textBox_Total_Des_Ennemi.Visible = false;
            label_vs.Visible = false;
            etatParagrapheAvantCombat = "";
            pictureBoxDe1Ennemi.Image = Image.FromFile(@"Images\Des\De6.png");
            pictureBoxDe2Ennemi.Image = Image.FromFile(@"Images\Des\De6.png");
            pictureBoxDe1Heros.Image = Image.FromFile(@"Images\Des\De6.png");
            pictureBoxDe2Heros.Image = Image.FromFile(@"Images\Des\De6.png");
            
            for (int i = listViewEquipement.Items.Count - 1; i >= 0; i--)
            {
                var item = listViewEquipement.Items[i];
                listViewEquipement.Items.Remove(item);
            }
            
            richTextBox1.Text = "NOUVELLE PARTIE" + "\n" + "Lancez les dés pour obtenir vos points d'HABILETÉ, POINTS DE VIE et CHANCE du héros";
            radioButton1.Text = "Lancez les dés";
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            radioButton5.Enabled = true;
            radioButton1.Checked = true;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            textBoxHabileteEnnemi.Text = "0";
            textBoxPDVEnnemi.Text = "0";
            textBoxPDVHeros.Text = "0";
            textBoxHabileteHeros.Text = "0";
            textBoxOr.Text = "0";
            textBoxChanceHeros.Text = "0";
            pictureBoxDe1Heros.Visible = false;
            pictureBoxDe2Heros.Visible = false;
            pictureBoxDe1Ennemi.Visible = false;
            pictureBoxDe2Ennemi.Visible = false;

        }

        /*************************************    www.oldbookillustrations.com       *******************************/
        /***********************************************************************************************************/
        /**************************************     Lecture <texte_debut>      *************************************/
        /***********************************************************************************************************/
        public string TexteEntreBalises(string texte, string texte_tag_debut, string texte_tag_fin)

        {
            string strTexte = texte;
            string StringFinale;
            int Pos1 = strTexte.IndexOf(texte_tag_debut) + texte_tag_debut.Length;
            int Pos2 = strTexte.IndexOf(texte_tag_fin);
            StringFinale = strTexte.Substring(Pos1, Pos2 - Pos1);

            return StringFinale;
        }

        /***********************************************************************************************************/
        /**************************************   Lecture <heros_image_debut>   ************************************/
        /***********************************************************************************************************/
        public string Chemin_Image_Heros_ArrierePlan_Ennemi_ou_Son(string texte, string balise_debut, string balise_fin)
        {
            string strTexte = texte;
            string StringFinale;
            int Pos1 = strTexte.IndexOf(balise_debut) + balise_debut.Length;
            int Pos2 = strTexte.IndexOf(balise_fin);
            StringFinale = strTexte.Substring(Pos1, Pos2 - Pos1);
            string cleaned = StringFinale.Replace("\n", "").Replace("\r", "");
            string cleaned2 = ".\\\\" + cleaned;

            return cleaned2;
        }

        
        /***********************************************************************************************************/
        /************************************** Lecture <ennemi_points_debut>    ***********************************/
        /***********************************************************************************************************/

        public string PointsEnnemiEntreBalises(string texte, string tag_ennemi_points_debut, string tag_ennemi_points_fin)
        {
            string strTexte = texte;
            string StringFinale;
            int Pos1 = strTexte.IndexOf(tag_ennemi_points_debut) + tag_ennemi_points_debut.Length;
            int Pos2 = strTexte.IndexOf(tag_ennemi_points_fin);
            StringFinale = strTexte.Substring(Pos1, Pos2 - Pos1);
            StringFinale.Replace("\n", "").Replace("\r", "").Replace("\\", "");
            return StringFinale;
        }

        /**************************************************************************************************************/
        /*Lecture balises <or_debut>,<points_de_chance_debut>,<pdv_debut>,<habilete_debut>,<tentez_votre_chance_debut>*/
        /**************************************************************************************************************/
        public string OrPointsdeChancePDVHabileteTentezVotreChance_EntreBalises(string texte, string tag_or_debut, string tag_or_fin)
        {
            string strTexte = texte;
            string StringFinale;
            int Pos1 = strTexte.IndexOf(tag_or_debut) + tag_or_debut.Length;
            int Pos2 = strTexte.IndexOf(tag_or_fin);
            StringFinale = strTexte.Substring(Pos1, Pos2 - Pos1);
            StringFinale.Replace("\n", "").Replace("\r", "").Replace("\\", "");
            return StringFinale;
        }

        /***********************************************************************************************************/
        /***********************************     Lecture balise <choix_paragraphes_debut>    **********************************/
        /***********************************************************************************************************/
        public (string bouton_un, string bouton_deux, string bouton_trois, string bouton_quatre, string bouton_cinq) ChoixParagraphe(string texte, string tag_choix_paragraphes_debut, string tag_choix_paragraphes_fin)
        {
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            radioButton5.Visible = true;
            string strTexte = texte;
            string StringFinale;
            int Pos1 = strTexte.IndexOf(tag_choix_paragraphes_debut) + tag_choix_paragraphes_debut.Length;
            int Pos2 = strTexte.IndexOf(tag_choix_paragraphes_fin);
            StringFinale = strTexte.Substring(Pos1, Pos2 - Pos1);

            string[] paragraphes = StringFinale.Split(';');
            int compteur = 0;

            string[] paragraphes_retour = new string[5] { "ND", "ND", "ND", "ND", "ND" };

            foreach (var paragraphe in paragraphes)
            {
                paragraphes_retour[compteur] = paragraphe;
                compteur++;
            }

            string chemin_sans_nr1 = paragraphes_retour[0].Replace("\n", "").Replace("\r", "");
            string retour1 = chemin_sans_nr1;
            string chemin_sans_nr2 = paragraphes_retour[1].Replace("\n", "").Replace("\r", "");
            string retour2 = chemin_sans_nr2;
            string chemin_sans_nr3 = paragraphes_retour[2].Replace("\n", "").Replace("\r", "");
            string retour3 = chemin_sans_nr3;
            string chemin_sans_nr4 = paragraphes_retour[3].Replace("\n", "").Replace("\r", "");
            string retour4 = chemin_sans_nr4;
            string chemin_sans_nr5 = paragraphes_retour[4].Replace("\n", "").Replace("\r", "");
            string retour5 = chemin_sans_nr5;

            if (retour1 == "ND")
            {
                radioButton1.Visible = false;
            }
            if (retour2 == "ND")
            {
                radioButton2.Visible = false;
            }
            if (retour3 == "ND")
            {
                radioButton3.Visible = false;
            }
            if (retour4 == "ND")
            {
                radioButton4.Visible = false;
            }
            if (retour5 == "ND")
            {
                radioButton5.Visible = false;
            }
            return (retour1, retour2, retour3, retour4, retour5);
        }

        /***********************************************************************************************************/
        /***********************************     Lecture du fichier .txt     ***************************************/
        /***********************************************************************************************************/

        public void Choix_Bouton(string paragraphe)
        {
            var path1 = @".\paragraphes\";
            var path = Path.Combine(Directory.GetCurrentDirectory(), path1 + paragraphe + ".txt");
            string texte = System.IO.File.ReadAllText(path);

            /***********************************************************************************************************/
            /***************************************Lecture balise <texte_debut>     **********************************/
            /***********************************************************************************************************/

            String texte_traite = TexteEntreBalises(texte, "<texte_debut>", "<texte_fin>");
            (string choix1, string choix2, string choix3, string choix4, string choix5) = ChoixParagraphe(texte, "<choix_paragraphes_debut>", "<choix_paragraphes_fin>");
            radioButton1.Text = "Allez au " + choix1;
            radioButton2.Text = "Allez au " + choix2;
            radioButton3.Text = "Allez au " + choix3;
            radioButton4.Text = "Allez au " + choix4;
            radioButton5.Text = "Allez au " + choix5;
            richTextBox1.Text = texte_traite;
            etatParagrapheAvantCombat = radioButton1.Text;
            radioButton1.Checked = true;

            /***********************************************************************************************************/
            /*********************** lecture <ennemi_points_debut> si présent alors il y a combat **********************/
            /***********************************************************************************************************/
            if (texte.Contains("<ennemi_points_debut>"))
            {
                if (texte.Contains("<ennemi_image_debut>"))
                {

                    string chemin_image_ennemi = Chemin_Image_Heros_ArrierePlan_Ennemi_ou_Son(texte, "<ennemi_image_debut>", "<ennemi_image_fin>");
                    if (chemin_image_ennemi==".\\\\")
                    {
                        MessageBox.Show("erreur dans le chemin de l`image de l`ennemi");
                    
                    }
                    else if ((Image.FromFile(chemin_image_ennemi).Height) <= 0)
                        {
                        MessageBox.Show("l`image semble non valide");

                        }
                    else
                    {
                        pictureBox_Ennemi.Image = Image.FromFile(chemin_image_ennemi);
                    }
                    
                }
                etatCombat = 1;
                string PointsEnnemi = PointsEnnemiEntreBalises(texte, "<ennemi_points_debut>", "<ennemi_points_fin>");
                string[] PointsEnnemiSansPointVirgule = PointsEnnemi.Split(';');
                textBoxHabileteEnnemi.Text = PointsEnnemiSansPointVirgule[0];
                textBoxPDVEnnemi.Text = PointsEnnemiSansPointVirgule[1];
                intPDVEnnemi = Int32.Parse(textBoxPDVEnnemi.Text);
                intHabileteEnnemi = Int32.Parse(textBoxHabileteEnnemi.Text);
                button1.Text = "Lancez les dés";
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                radioButton5.Enabled = false;
            }
            

            /***********************************************************************************************************/
            /**************************************     Lecture <or_debut>    **********************************/
            /***********************************************************************************************************/

            if (texte.Contains("<or_debut>"))
            {
                intOr = Int32.Parse(textBoxOr.Text);
                string strOr = OrPointsdeChancePDVHabileteTentezVotreChance_EntreBalises(texte, "<or_debut>", "<or_fin>");
                int intOrTemp = Int32.Parse(strOr);
                intOr += intOrTemp;
                if (intOr < 0)
                {
                    intOr = 0;
                    textBoxOr.Text = "0";
                }
                textBoxOr.Text = intOr.ToString();
            }

            /***********************************************************************************************************/
            /**************************************     Lecture <habilete_debut>    **********************************/
            /***********************************************************************************************************/

            if (texte.Contains("<habilete_debut>"))
            {
                intHabileteHeros = Int32.Parse(textBoxHabileteHeros.Text);
                string strHabilete = OrPointsdeChancePDVHabileteTentezVotreChance_EntreBalises(texte, "<habilete_debut>", "<habilete_fin>");
                int intHabileteTemp = Int32.Parse(strHabilete);
                intHabileteHeros += intHabileteTemp;
                if (intHabileteHeros<=0)
                {
                    intHabileteHeros = 0;
                    
                }
                textBoxHabileteHeros.Text = intHabileteHeros.ToString();
            }

            /***********************************************************************************************************/
            /************************************ Lecture <points_de_chance_debut>      ********************************/
            /***********************************************************************************************************/

            if (texte.Contains("<points_de_chance_debut>"))
            {
                intChanceHeros = Int32.Parse(textBoxChanceHeros.Text);
                string strPointsDeChance = OrPointsdeChancePDVHabileteTentezVotreChance_EntreBalises(texte, "<points_de_chance_debut>", "<points_de_chance_fin>");
                int intPointsDeChanceTemp = Int32.Parse(strPointsDeChance);
                intChanceHeros += intPointsDeChanceTemp;
                if (intChanceHeros <= 0)
                {
                    intChanceHeros = 0;

                }
                textBoxChanceHeros.Text = intChanceHeros.ToString();
            }

            /***********************************************************************************************************/
            /**************************************     Lecture <pdv_debut>    **********************************/
            /***********************************************************************************************************/

            if (texte.Contains("<pdv_debut>"))
            {
                intPDVHeros = Int32.Parse(textBoxPDVHeros.Text);
                string strPDVHeros = OrPointsdeChancePDVHabileteTentezVotreChance_EntreBalises(texte, "<pdv_debut>", "<pdv_fin>");
                int intPDVHerosTemp = Int32.Parse(strPDVHeros);
                intPDVHeros += intPDVHerosTemp;
                if (intPDVHeros <= 0)
                {
                    MessageBox.Show("Vous êtes mort");
                    pictureBox_Heros.Image = Image.FromFile(@"Images\mort_ennemi_mort.png");
                    
                    
                    Initialisation_Debut();
                }
                textBoxPDVHeros.Text = intPDVHeros.ToString();
            }

            /***********************************************************************************************************/
            /**************************************     Lecture <fin_debut>    *****************************************/
            /***********************************************************************************************************/

            if (texte.Contains("<fin_debut>"))
            {
                string strFin = OrPointsdeChancePDVHabileteTentezVotreChance_EntreBalises(texte, "<fin_debut>", "<fin_fin>");
                int intFin = Int32.Parse(strFin);
                if (intFin == 1)
                {
                    MessageBox.Show("Bravo!", "Vous avez gagné");
                    Initialisation_Debut();
                }
            }

            /***********************************************************************************************************/
            /**************************************     Lecture <son_debut>    *****************************************/
            /***********************************************************************************************************/

            if (texte.Contains("<son_debut>"))
            {
                string strSon = Chemin_Image_Heros_ArrierePlan_Ennemi_ou_Son(texte, "<son_debut>", "<son_fin>");
                Son(strSon);
            }


            /***********************************************************************************************************/
            /**************************************     Lecture <equipement_debut>    **********************************/
            /***********************************************************************************************************/

            if (texte.Contains("<equipement_debut>"))
            {
                string strEquipement = PointsEnnemiEntreBalises(texte.ToLower(), "<equipement_debut>", "<equipement_fin>");
                string[] strEquipementSansPointVirgule = strEquipement.Split(';');
                string strEquipementIsole = strEquipementSansPointVirgule[0];
                string strEnleverLignes = strEquipementIsole.Replace("\n", "").Replace("\r", "").Replace("\\", "");
                
                if (strEnleverLignes[0] == '-')
                {
                    strEnleverLignes = strEnleverLignes.Substring(1);

                    for (int i = listViewEquipement.Items.Count - 1; i >= 0; i--)
                    {
                        var item = listViewEquipement.Items[i];
                        if (item.Text.Contains(strEnleverLignes))
                        {
                            string stModifHabilete = listViewEquipement.Items[i].SubItems[1].Text;
                            string stModifPDV = listViewEquipement.Items[i].SubItems[2].Text;
                            string stModifChance = listViewEquipement.Items[i].SubItems[3].Text;
                            int intModifHabilete = Int32.Parse(stModifHabilete);
                            int intModifPDV = Int32.Parse(stModifPDV);
                            int intModifChance = Int32.Parse(stModifChance);

                            if (intModifHabilete < 0)
                            {
                                intHabileteHeros += intModifHabilete;
                            }
                            if (intModifPDV <0 )
                            {
                                intPDVHeros += intModifPDV;
                            }
                            if (intModifChance < 0)
                            {
                                intChanceHeros += intModifChance;
                            }

                            if (intModifHabilete > 0)
                            {
                                intHabileteHeros -= intModifHabilete;
                            }
                            if (intModifPDV > 0)
                            {
                                intPDVHeros -= intModifPDV;
                            }
                            if (intModifChance > 0)
                            {
                                intChanceHeros -= intModifChance;
                            }

                            MessageBox.Show("Vous n'avez plus : " + strEnleverLignes + " Vous perdez " + intModifHabilete + " Habilete " + intModifPDV + " PDV " + intModifChance + " Chance");
                            listViewEquipement.Items.Remove(item);
                        }
                    }

                }

                else
                {
                    ListViewItem itm;
                    itm = new ListViewItem(strEquipementSansPointVirgule);
                    listViewEquipement.Items.Add(itm);
                    intHabileteHeros += Int32.Parse(strEquipementSansPointVirgule[1]);
                    intPDVHeros += Int32.Parse(strEquipementSansPointVirgule[2]);
                    intChanceHeros += Int32.Parse(strEquipementSansPointVirgule[3]);
                }

                textBoxHabileteHeros.Text = intHabileteHeros.ToString();
                textBoxPDVHeros.Text = intPDVHeros.ToString();
                textBoxChanceHeros.Text = intChanceHeros.ToString();

            }

            /***********************************************************************************************************/
            /***************************************     lecutre <equipement2_debut>     *******************************/
            /***********************************************************************************************************/
            if (texte.Contains("<equipement2_debut>"))
            {
                string strEquipement = PointsEnnemiEntreBalises(texte.ToLower(), "<equipement2_debut>", "<equipement2_fin>");
                string[] strEquipementSansPointVirgule = strEquipement.Split(';');
                string strEquipementIsole = strEquipementSansPointVirgule[0];
                string strEnleverLignes = strEquipementIsole.Replace("\n", "").Replace("\r", "").Replace("\\", "");

                if (strEnleverLignes[0] == '-')
                {
                    strEnleverLignes = strEnleverLignes.Substring(1);

                    for (int i = listViewEquipement.Items.Count - 1; i >= 0; i--)
                    {
                        var item = listViewEquipement.Items[i];
                        if (item.Text.Contains(strEnleverLignes))
                        {
                            string stModifHabilete = listViewEquipement.Items[i].SubItems[1].Text;
                            string stModifPDV = listViewEquipement.Items[i].SubItems[2].Text;
                            string stModifChance = listViewEquipement.Items[i].SubItems[3].Text;
                            int intModifHabilete = Int32.Parse(stModifHabilete);
                            int intModifPDV = Int32.Parse(stModifPDV);
                            int intModifChance = Int32.Parse(stModifChance);

                            if (intModifHabilete < 0)
                            {
                                intHabileteHeros += intModifHabilete;
                            }
                            if (intModifPDV < 0)
                            {
                                intPDVHeros += intModifPDV;
                            }
                            if (intModifChance < 0)
                            {
                                intChanceHeros += intModifChance;
                            }

                            if (intModifHabilete > 0)
                            {
                                intHabileteHeros -= intModifHabilete;
                            }
                            if (intModifPDV > 0)
                            {
                                intPDVHeros -= intModifPDV;
                            }
                            if (intModifChance > 0)
                            {
                                intChanceHeros -= intModifChance;
                            }

                            MessageBox.Show("Vous n'avez plus : " + strEnleverLignes + " Vous perdez " + intModifHabilete + " Habilete " + intModifPDV + " PDV " + intModifChance + " Chance");
                            listViewEquipement.Items.Remove(item);
                        }
                    }

                    
                }

                else
                {
                    ListViewItem itm;
                    itm = new ListViewItem(strEquipementSansPointVirgule);
                    listViewEquipement.Items.Add(itm);
                    intHabileteHeros += Int32.Parse(strEquipementSansPointVirgule[1]);
                    intPDVHeros += Int32.Parse(strEquipementSansPointVirgule[2]);
                    intChanceHeros += Int32.Parse(strEquipementSansPointVirgule[3]);
                }

                textBoxHabileteHeros.Text = intHabileteHeros.ToString();
                textBoxPDVHeros.Text = intPDVHeros.ToString();
                textBoxChanceHeros.Text = intChanceHeros.ToString();
            }

           
            /***********************************************************************************************************/
            /****************************************     lecture <tentez_votre_chance_debut>     ***********************************/
            /***********************************************************************************************************/

            if (texte.Contains("<tentez_votre_chance_debut>"))
            {
                //jeter 2 dés, si le total est inférieur ou égal aux points de chance, vous êtes chanceux
                //à chaque utilisation de la chance, vous perdez un point de chance
                //à chaque tentative de chance vous perdez un point de chance
                //si vous indiquez 0 entre les balises <tentez_votre_chance_debut> et <tentez_votre_chance_fin>, cela signifie que vous tentez votre chance
                //si vous spécifiez un entier postif ou négatif, il sera traité comme un gain ou une perte de votre total de chance

                intChanceHeros = Int32.Parse(textBoxChanceHeros.Text);
                string strChance = OrPointsdeChancePDVHabileteTentezVotreChance_EntreBalises(texte, "<tentez_votre_chance_debut>", "<tentez_votre_chance_fin>");
                int intChanceTemp = Int32.Parse(strChance);
                if (intChanceTemp == 1)
                {

                    MessageBox.Show("Vous tentez votre chance", "Tentez votre chance");
                    int de1 = Rouler_un_de();
                    int de2 = Rouler_un_de();
                    Afficher_Resultat_De(1, de1);
                    Afficher_Resultat_De(2, de2);
                    Son_2des();
                    int total_des_chance = de1 + de2;

                    if (total_des_chance <= intChanceHeros)
                    {
                        MessageBox.Show("Vous êtes chanceux");
                        radioButton2.Visible = false;
                        radioButton1.Checked = true;

                    }

                    else
                    {
                        MessageBox.Show("Vous êtes malchanceux");
                        intChanceHeros--;
                        radioButton1.Visible = false;
                        radioButton2.Checked = true;
                    }

                    textBoxChanceHeros.Text = intChanceHeros.ToString();


                }


                intChanceHeros += intChanceTemp;
                textBoxChanceHeros.Text = intChanceHeros.ToString();
                if (intChanceHeros < 0)
                {
                    intChanceHeros = 0;
                    textBoxChanceHeros.Text = "0";
                }
            }
        }


        /***********************************************************************************************************/
        /***********************************************  Bouton Action   ******************************************/
        /***********************************************************************************************************/
        private void Button1_Click(object sender, EventArgs e)
        {

            /***********************************************************************************************************/
            /************* Premières actions déterminer Habileté, Chance et PDV du Héros *******************************/
            /***********************************************************************************************************/
            if (intDesDebutHabPDVChance == 0)
            {
                MessageBox.Show("Habileté : 6 sera jouté au chiffre obtenu au dé lancé", "HABILETÉ");
                pictureBoxDe1Heros.Visible = true;
                int de1 = Rouler_un_de();
                Afficher_Resultat_De(1, de1);
                intHabileteHeros = 6 + de1; //1 dé + 6
                textBoxHabileteHeros.Text = intHabileteHeros.ToString();
                Son_1de();

                MessageBox.Show("Chance : 6 sera jouté au chiffre obtenu au dé lancé", "CHANCE");
                de1 = Rouler_un_de();
                Afficher_Resultat_De(1, de1);
                intChanceHeros = 6 + de1; //1 dé + 6
                textBoxChanceHeros.Text = intChanceHeros.ToString();
                Son_1de();


                MessageBox.Show("Points de vie : 12 points seront ajoutés au total des 2 dés lancés", "POINTS DE VIE");
                pictureBoxDe2Heros.Visible = true;
                de1 = Rouler_un_de();
                int de2 = Rouler_un_de();
                Son_2des();
                Afficher_Resultat_De(1, de1);
                Afficher_Resultat_De(2, de2);
                int total_des_debut = de1 + de2;
                intPDVHeros = 12 + total_des_debut;  //2 dés + 12
                textBoxPDVHeros.Text = intPDVHeros.ToString();
                pictureBoxDe1Heros.Refresh();
                pictureBoxDe2Heros.Refresh();

                intDesDebutHabPDVChance++;
                pictureBoxDe1Ennemi.Visible = true;
                pictureBoxDe2Ennemi.Visible = true;
                radioButton1.Text = "Allez au 000";

                /***********************************************************************************************************/
                /********************************** Lecture du fichier 000.txt pour débuter l'aventure**********************/
                /***********************************************************************************************************/
                pictureBox_Heros.Visible = true;
                pictureBox_Ennemi.Visible = true;
                string texte = System.IO.File.ReadAllText(@"paragraphes\000.txt");
                string texte_traite = TexteEntreBalises(texte, "<texte_debut>", "<texte_fin>");
                string texte_chemin_heros = Chemin_Image_Heros_ArrierePlan_Ennemi_ou_Son(texte, "<heros_image_debut>", "<heros_image_fin>");
                if (texte_chemin_heros == ".\\\\")
                {
                    MessageBox.Show("erreur dans le chemin de l'image du héros");
                }
                else if ((Image.FromFile(texte_chemin_heros).Height) <= 0)
                {
                    MessageBox.Show("l'image semble non valide");
                }
                else
                {
                    pictureBox_Heros.Image = Image.FromFile(texte_chemin_heros);
                }

                string texte_chemin_arriereplan = Chemin_Image_Heros_ArrierePlan_Ennemi_ou_Son(texte, "<arriere_plan_image_debut>", "<arriere_plan_image_fin>");
                if (texte_chemin_arriereplan == ".\\\\")
                {
                    MessageBox.Show("erreur dans le chemin de l'image de l'arrière plan");
                }
                else if ((Image.FromFile(texte_chemin_arriereplan).Height) <= 0)
                {
                    MessageBox.Show("l'image de l'arrière plan semble non valide");
                }
                else
                {
                    panelHerosEnnemi.BackgroundImage = Image.FromFile(texte_chemin_arriereplan);
                }



                (string choix1, string choix2, string choix3, string choix4, string choix5) = ChoixParagraphe(texte, "<choix_paragraphes_debut>", "<choix_paragraphes_fin>");

                radioButton1.Text = "Allez au " + choix1;
                radioButton2.Text = "Allez au " + choix2;
                radioButton3.Text = "Allez au " + choix3;
                radioButton4.Text = "Allez au " + choix4;
                radioButton5.Text = "Allez au " + choix5;
                richTextBox1.Text = texte_traite;
                radioButton1.Checked = true;
                
            }

            /***********************************************************************************************************/
            /******   Si le héros a ses points d'habilté, PDV et de chance alors traitement dans le else     ***********/
            /***********************************************************************************************************/

            else
            {   /****************************************************************************************************************************/
                /**** si le fichier .txt contient la baslie <ennemi_image_debut>, la variable etatCombat s'est placée  préalablement à 1 ****/
                /****************************************************************************************************************************/
                if (etatCombat == 1)
                {
                                       

                    if (intPDVEnnemi > 0 && intPDVHeros > 0)
                    {
                        textBox_Total_Des_Heros.Visible = true;
                        textBox_Total_Des_Ennemi.Visible = true;
                        label_vs.Visible = true;
                        Random rnd = new Random();
                        int sleep_time_random = rnd.Next(1, 30);
                        int de1 = Rouler_un_de();
                        System.Threading.Thread.Sleep(sleep_time_random);
                        int de2 = Rouler_un_de();
                        System.Threading.Thread.Sleep(sleep_time_random);
                        int de3 = Rouler_un_de();
                        System.Threading.Thread.Sleep(sleep_time_random);
                        int de4 = Rouler_un_de();

                        Afficher_Resultat_De(1, de1);
                        Afficher_Resultat_De(2, de2);
                        Afficher_Resultat_De(3, de3);
                        Afficher_Resultat_De(4, de4);
                        Son_2des();

                        // gestion du combat (dés Heros + habileté Heros) vs (dés Ennemi + Habileté Ennemi)

                        textBox_Total_Des_Heros.Text = (de1 + de2 + intHabileteHeros).ToString();
                        textBox_Total_Des_Ennemi.Text = (de3 + de4 + intHabileteEnnemi).ToString();

                        if ((de1 + de2 + intHabileteHeros) > (de3 + de4 + intHabileteEnnemi))
                        {
                            textBox_Total_Des_Heros.BackColor = Color.FromArgb(231, 228, 20);  // jaune
                            textBox_Total_Des_Ennemi.BackColor= Color.FromArgb(169, 44, 44); // rouge
                            intPDVEnnemi += -2;
                            if (intPDVEnnemi < 0)
                            {
                                intPDVEnnemi = 0;
                            }
                        }

                        if ((de1 + de2 + intHabileteHeros) < (de3 + de4 + intHabileteEnnemi))
                        {
                            textBox_Total_Des_Heros.BackColor = Color.FromArgb(169, 44, 44); // rouge
                            textBox_Total_Des_Ennemi.BackColor = Color.FromArgb(231, 228, 20);// jaune
                            intPDVHeros += -2;
                            if (intPDVHeros<0)
                            { 
                                intPDVHeros = 0;
                            }
                        }
                        if ((de1 + de2 + intHabileteHeros) == (de3 + de4 + intHabileteEnnemi))
                        {
                            textBox_Total_Des_Heros.BackColor = Color.FromArgb(169, 44, 44); // rouge
                            textBox_Total_Des_Ennemi.BackColor = Color.FromArgb(169, 44, 44); // rouge
                            intPDVEnnemi--;
                            intPDVHeros--;
                        }
                        textBoxPDVHeros.Text = intPDVHeros.ToString();
                        textBoxPDVEnnemi.Text = intPDVEnnemi.ToString();

                        if (intPDVEnnemi <= 0)
                        {
                            MessageBox.Show("Vous avez tué l'ennemi");
                            radioButton1.Text = etatParagrapheAvantCombat;
                            etatCombat = 0;
                            //pictureBox_Ennemi.Image = Image.FromFile(@"Images\mort_ennemi_mort.png");
                            numeroParagraphe = etatParagrapheAvantCombat;
                            textBoxHabileteEnnemi.Text = "0";
                            textBoxPDVEnnemi.Text = "0";
                            radioButton1.Enabled = true;
                            radioButton2.Enabled = true;
                            radioButton3.Enabled = true;
                            radioButton4.Enabled = true;
                            radioButton5.Enabled = true;
                            button1.Text = "Action";
                            textBox_Total_Des_Heros.Visible = false;
                            textBox_Total_Des_Ennemi.Visible = false;
                            label_vs.Visible = false;
                            pictureBox_Ennemi.Image = null;

                        }
                        if (intPDVHeros <= 0)
                        {
                            MessageBox.Show("Vous êtes mort");
                            Initialisation_Debut();
                        }

                     
            }//fin du if (intPDVEnnemi > 0 && intPDVHeros > 0)
        } // fin du (etatCombat==1)


                /***************************************************************************************************************
                 * Si toutes les balises ont été traitées alors il faut ajuster les radioButtons *******************************
                 * ************************************************************************************************************/
                else
                {
                    {
                        textBox_Total_Des_Heros.Visible = false;
                        textBox_Total_Des_Ennemi.Visible = false;
                        label_vs.Visible = false;
                        radioButton1.Visible = true;
                        String NouvelleValeurRadioButton;

                        if (radioButton1.Checked == true)
                        {
                            NouvelleValeurRadioButton = radioButton1.Text.Replace("Allez au ", "");
                            numeroParagraphe = NouvelleValeurRadioButton;
                        }

                        if (radioButton2.Checked == true)
                        {
                            NouvelleValeurRadioButton = radioButton2.Text.Replace("Allez au ", "");
                            numeroParagraphe = NouvelleValeurRadioButton;
                        }

                        if (radioButton3.Checked == true)
                        {
                            NouvelleValeurRadioButton = radioButton3.Text.Replace("Allez au ", "");
                            numeroParagraphe = NouvelleValeurRadioButton;
                        }

                        if (radioButton4.Checked == true)
                        {
                            NouvelleValeurRadioButton = radioButton4.Text.Replace("Allez au ", "");
                            numeroParagraphe = NouvelleValeurRadioButton;
                        }

                        if (radioButton5.Checked == true)
                        {
                            NouvelleValeurRadioButton = radioButton5.Text.Replace("Allez au ", "");
                            numeroParagraphe = NouvelleValeurRadioButton;
                        }
                        Choix_Bouton(numeroParagraphe);
                    }
                }
            }
        }

        /***********************************************************************************************************/
        /******************************************  fonction Rouler_un_de   ***************************************/
        /***********************************************************************************************************/
        private int Rouler_un_de()
        {
            Random rnd = new Random();
            int sleep_time_random = rnd.Next(1, 30);
            System.Threading.Thread.Sleep(sleep_time_random);
            int de1 = rnd.Next(1, 7);
            return de1;
        }

        /***********************************************************************************************************/
        /******************************************  fonction Jouer son de 2 dés   *********************************/
        /***********************************************************************************************************/
        private void Son_2des()
        {
            SoundPlayer player = new SoundPlayer
            {
                SoundLocation = (@"sons\son_des.wav")
            };
            player.Play();
        }

        /***********************************************************************************************************/
        /******************************************  fonction Jouer son de 1 dé   *********************************/
        /***********************************************************************************************************/
        private void Son_1de()
        {
            SoundPlayer player = new SoundPlayer
            {
                SoundLocation = (@"sons\son_1de.wav")
            };
            player.Play();
        }

        /***********************************************************************************************************/
        /******************************************  fonction Jouer son  *******************************************/
        /***********************************************************************************************************/
        private void Son(string strSon)
        {
            SoundPlayer player = new SoundPlayer
            {
                SoundLocation = (strSon)
            };
            player.Play();
        }



        /***********************************************************************************************************/
        /********************************************  fonction Afficher Des   *************************************/
        /***********************************************************************************************************/
        private void Afficher_Resultat_De(int position_de, int resultat_de)
        {
            if (position_de == 1)
            {
                switch (resultat_de)
                {
                    case 1:
                        pictureBoxDe1Heros.Image = Image.FromFile(@"Images\Des\De1.png");
                        break;
                    case 2:

                        pictureBoxDe1Heros.Image = Image.FromFile(@"Images\Des\De2.png");
                        break;
                    case 3:
                        pictureBoxDe1Heros.Image = Image.FromFile(@"Images\Des\De3.png");
                        break;
                    case 4:
                        pictureBoxDe1Heros.Image = Image.FromFile(@"Images\Des\De4.png");
                        break;
                    case 5:
                        pictureBoxDe1Heros.Image = Image.FromFile(@"Images\Des\De5.png");
                        break;
                    case 6:
                        pictureBoxDe1Heros.Image = Image.FromFile(@"Images\Des\De6.png");
                        break;
                }
            }
            if (position_de == 2)
            {
                switch (resultat_de)
                {
                    case 1:
                        pictureBoxDe2Heros.Image = Image.FromFile(@"Images\Des\De1.png");
                        break;
                    case 2:

                        pictureBoxDe2Heros.Image = Image.FromFile(@"Images\Des\De2.png");
                        break;
                    case 3:
                        pictureBoxDe2Heros.Image = Image.FromFile(@"Images\Des\De3.png");
                        break;
                    case 4:
                        pictureBoxDe2Heros.Image = Image.FromFile(@"Images\Des\De4.png");
                        break;
                    case 5:
                        pictureBoxDe2Heros.Image = Image.FromFile(@"Images\Des\De5.png");
                        break;
                    case 6:
                        pictureBoxDe2Heros.Image = Image.FromFile(@"Images\Des\De6.png");
                        break;
                }
            }
            if (position_de == 3)
            {
                switch (resultat_de)
                {
                    case 1:
                        pictureBoxDe1Ennemi.Image = Image.FromFile(@"Images\Des\De1.png");
                        break;
                    case 2:

                        pictureBoxDe1Ennemi.Image = Image.FromFile(@"Images\Des\De2.png");
                        break;
                    case 3:
                        pictureBoxDe1Ennemi.Image = Image.FromFile(@"Images\Des\De3.png");
                        break;
                    case 4:
                        pictureBoxDe1Ennemi.Image = Image.FromFile(@"Images\Des\De4.png");
                        break;
                    case 5:
                        pictureBoxDe1Ennemi.Image = Image.FromFile(@"Images\Des\De5.png");
                        break;
                    case 6:
                        pictureBoxDe1Ennemi.Image = Image.FromFile(@"Images\Des\De6.png");
                        break;

                }
            }
            if (position_de == 4)
            {
                switch (resultat_de)
                {
                    case 1:
                        pictureBoxDe2Ennemi.Image = Image.FromFile(@"Images\Des\De1.png");
                        break;
                    case 2:
                        pictureBoxDe2Ennemi.Image = Image.FromFile(@"Images\Des\De2.png");
                        break;
                    case 3:
                        pictureBoxDe2Ennemi.Image = Image.FromFile(@"Images\Des\De3.png");
                        break;
                    case 4:
                        pictureBoxDe2Ennemi.Image = Image.FromFile(@"Images\Des\De4.png");
                        break;
                    case 5:
                        pictureBoxDe2Ennemi.Image = Image.FromFile(@"Images\Des\De5.png");
                        break;
                    case 6:
                        pictureBoxDe2Ennemi.Image = Image.FromFile(@"Images\Des\De6.png");
                        break;

                }

            }
        }
    }
}
