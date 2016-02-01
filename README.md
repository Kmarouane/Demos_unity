#Projet Serious Game



###Niveau 1	
Le but est de faire tomber tous les dominos en affectant � chacun une couleur d�finie. 
L'ordre d'affectation est "Rouge, Vert, Bleu, Rouge, Vert, Bleu.....etc". 
La sc�ne se composent de deux armoires celle de droite est destin�e a recevoir le cube de la couleur et celle de gauche est destin�e a recevoir le cube de l'it�ration (N pour suivant et P pour pr�c�dent).
Apr�s chaque affectation, on peut passer � l'it�ration suivant en effectuant un "Drag & Drop" du cube "N" dans l'armoire de droite, on peut revenir � l'it�ration pr�c�dente � l'aide du cube P.
Pour "Drag & Drop" un cube, positionnez le curseur de la souris sur ce dernier et appuyez sur "espace" un deuxi�me appui sur la touche "espace" relachera le cube.
Les forces de la physique ne s'appliquent � un domino que s'il a la bonne couleur. 

Solution:
* glissez-d�posez le cube de couleur rouge dans l'armoire de gauche de fa�on � ce qu'il soit bien positionn�, si tout se passe bien le domino n�1 sur l'�cran verra sa couleur changer en rouge.
* glissez-d�posez le cube N dans l'armoire de droite pour passer � l'it�ration suivant.
* recommencer l'�tape 1 mais avec la couleur verte cette fois-ci.
* r�it�rez le proc�d� en suivant cet ordre : rouge-vert-bleu-rouge-vert-bleu.
	
###Niveau 2 
Dans ce niveau le joueur devra construire l'algorithme ad�quat afin de faire tomber la s�rie de dominos qu'il devra initialiser au pr�alable, pour ce faire:
* Initialisation en pla�ant les bons cubes dans les bons tiroires de l'armoire rouge (celle de gauche)
* Construction de l'algorithme en pla�ant les bons cubes dans les bons tiroires de l'armoire verte (celle de droite)
En bas de chaque armoire se trouve un bouton "play" qui permet de lancer l'algorithme.