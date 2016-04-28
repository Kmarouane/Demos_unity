#Projet Serious Game



###Niveau 1	
Le but est de faire tomber tous les dominos en affectant à chacun une couleur définie. 
L'ordre d'affectation est "Rouge, Vert, Bleu, Rouge, Vert, Bleu.....etc". 
La scène se composent de deux armoires celle de droite est destinée a recevoir le cube de la couleur et celle de gauche est destinée a recevoir le cube de l'itération (N pour suivant et P pour précédent).
Après chaque affectation, on peut passer à l'itération suivant en effectuant un "Drag & Drop" du cube "N" dans l'armoire de droite, on peut revenir à l'itération précédente à l'aide du cube P.
Pour "Drag & Drop" un cube, positionnez le curseur de la souris sur ce dernier et appuyez sur "espace" un deuxième appui sur la touche "espace" relachera le cube.
Les forces de la physique ne s'appliquent à un domino que s'il a la bonne couleur. 

Solution:
* glissez-déposez le cube de couleur rouge dans l'armoire de gauche de façon à ce qu'il soit bien positionné, si tout se passe bien le domino n°1 sur l'écran verra sa couleur changer en rouge.
* glissez-déposez le cube N dans l'armoire de droite pour passer à l'itération suivant.
* recommencer l'étape 1 mais avec la couleur verte cette fois-ci.
* réitérez le procédé en suivant cet ordre : rouge-vert-bleu-rouge-vert-bleu.

A la fin de ce niveau la porte de droite s'ouvre et vous pouvez passer au niveau suivant.


###Niveau 2 
Le but de ce niveau est d'ouvrir la porte blindée. Pour ce faire, le joueur devra construire l'algorithme en utilisant la notion du TANTQUE. Plusieurs animations ont été ajoutées ainsi qu'un éclairage amélioré.
Astuce : 
* La porte s'ouvre quand l'énergie suffisante est cumulée, un pupitre affiche l'état en temps réel.
* Afin de générer de l'énergie, il faudra faire courir le chien sur le tapis présent dans la salle.

 	
###Niveau 3
Le but de ce niveau est d'expliquer la notion de la boucle "for". Le joueur devra construire lui même le niveau en faisant apparître les objets voulus ( semi sandbox).
Pour le moment il faudra faire tomber tous les dominos à condition que l'algorithme affichée sur le télévisur soit respecté.
La particularité de ce niveau est l'utilisation d'effets de particules et de textures animées.


###Niveau4
Dans ce niveau le joueur devra construire l'algorithme adéquat afin de faire tomber la série de dominos qu'il devra initialiser au préalable, pour ce faire:
* Initialisation en plaçant les bons cubes dans les bons tiroires de l'armoire rouge (celle de gauche)
* Construction de l'algorithme en plaçant les bons cubes dans les bons tiroires de l'armoire verte (celle de droite)

En bas de chaque armoire se trouve un bouton "play" qui permet de lancer l'algorithme.


###Niveau5
* Parler au pharaon
* Construire l'algorithme à l'aide des cubes situés à l'arrière de la trappe à gauche de la stèle.
* Solution :
	* Pour K Allant de 0 à TailleZ
	* Pour I Allant de 0 à TailleX
	* Pour J Allant de 0 à TailleY
	* Poser une pierre X-J Y+K Z+I
	* Décrémenter x2 TailleX
	* Décrémenter x2 TailleY