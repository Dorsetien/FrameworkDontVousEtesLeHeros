# FrameworkDontVousEtesLeHeros
# https://sites.google.com/view/fdvelh

C# Windows Forms, .net Framework 4.7.2

Framework dans lequel vous devez éditer uniquement des fichiers textes pour créer votre Jeu dont vous êtes le héros du type "Défis Fantastiques"

/****
IMPORTANT : Allez dans le sous-répertoire bin\debug pour exécuter le logiciel (.exe) et placer vos fichiers.
****/

Chaque fichier (paragraphe) peut contenir :

- du texte
- un maximum de 5 choix par fichier
- une image pour votre héros à partir du répertoire bin\Debug\images
- afficher les images de vos ennemis dans le répertoire bin\Debug\images
- les points d'habileté et points de vie de l'ennemi
- modification de la quantité d'or, des points d'habileté, points de vie, points de chance
- possibilité de gérer 2 équipements par fichiers
- gestion de la "tentez votre chance"
- une image pour votre arriere plan à partir du répertoire bin\Debug\images
- gestion des combats avec dés
- les sons des dés sont inclus

La ligne qui est lue et traitée est celle qui se situe entre des balises spécifiques de type <NomBalise_debut> et <NomBalise_fin>

Voici les balises disponibles pour modifier ce qui se produit à chaque fichier(paragraphe):

<texte_debut>
ajouter texte seulement entre ces balises
<texte_fin>

<choix_paragraphes_debut>
001;002;003;004;005 (5 choix max toujours sous la forme du nom de fichier qui se situe dans bin\Debug\paragraphes)
<choix_paragraphes_fin>

<heros_image_debut>
images\\000-heros.png
<heros_image_fin>

<ennemi_image_debut>
images\\003-demon_volant.jpg
<ennemi_image_fin>

<ennemi_points_debut>
8;7 (habileté, pdv)
<ennemi_points_fin>

<or_debut>
Ex : 8 ou -8 (ajout de 8 pièces d'or ou soustraire 8 pièces d'or)
<or_fin>

<equipement_debut>
Arc;1;1;1 (nom; chiffre qui influcence l'habilete(entier positif ou négatif); chiffre qui influence les points de vie(entier positif ou négatif);chiffre qui influence vos points de chance(entier positif ou négatif))
<equipement_fin>

<equipement2_debut>
Bouclier;2;2;2 (nom;chiffre qui influcence votre habileté(+ ou -); chiffre qui influcence vos points de vies (+ ou -);chiffre qui influence votre chance(+ ou -)
<equipement2_fin>

<tentez_votre_chance_debut>
1 (inscrire 1 pour déclancher un "tentez votre chance")
<tentez_votre_chance_fin>

<habilete_debut>
3 ou -3 (Entier positif ou négatif pour modifier votre habileté dans le fichier(paragraphe))
<habilete_fin>

<pdv_debut>
3 ou -3 (entier positif ou négatif pour modifier vos points de vie dans le fichier(paragraphe))
<pdv_fin>

<points_de_chance_debut>
3 ou -3 (entier positif ou négatif pour modifier vos points de chance)
<points_de_chance_fin>

<fin_debut>
1  (si 1 est indiqué, il s'agit de votre dernier fichier(paragraphe), c'est le paragraphe final (Victoire!)
<fin_fin>

<arriere_plan_image_debut>
images\\000-arriere-plan.png
<arriere_plan_image_fin>

// Pour mieux comprendre, télécharger le programme, exécuter le .exe et regarder les fichiers présents dans la structure sous bin\debug.  // Faites vos premières modifications à certains fichiers et voyez les résultats.
