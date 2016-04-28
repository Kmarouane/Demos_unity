#Projet Serious Game

###Installation de l'Oculus Rift
*	T�l�charger et installer le Runtime disponible � l'adresse : https://developer.oculus.com/downloads/pc/0.8.0.0-beta/Oculus_Runtime_for_Windows/
*	Un red�marrage de la machine est recommand�.

###Utilisation de l'Oculus Rift
>	Si sous Windows 10, effectuer les �tapes ci-dessous en mode compatibilit� Windows 7/8 et en tant qu'administrateur).

*	Rep�rer le dossier d'installation et ex�cuter le serveur OVR (Oculus/Service/OVRServer_x64).
*	Lancer l'utilitaire de configuration Oculus � partir de la zone des ic�nes cach�es (pr�s de l'horloge).
*	Brancher le c�ble USB de l'Oculus sur un port USB de la machine (fait office d'alimentation).
*	Brancher le c�ble HDMI de l'Oculus sur le port HDMI de la machine.
*	Si tout se passe bien, L'utilitaire affichera le message suivant:
> Oculus Rift DK2 Attached, No Tracker Attached
*	Lancer Unity et s'assurer que la VR est activ�e en allant dans : Edit/Project Settings/Player, la case Virtual Reality Supported devra �tre coch�e.
*	Lancer le jeu soit en appuyant sur la boutton PLAY (fl�che en haut) soit en allant dans Edit/Play. 

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

A la fin de ce niveau la porte de droite s'ouvre et vous pouvez passer au niveau suivant.


###Niveau 2 
Le but de ce niveau est d'ouvrir la porte blind�e. Pour ce faire, le joueur devra construire l'algorithme en utilisant la notion du TANTQUE. Plusieurs animations ont �t� ajout�es ainsi qu'un �clairage am�lior�.
Astuce : 
* La porte s'ouvre quand l'�nergie suffisante est cumul�e, un pupitre affiche l'�tat en temps r�el.
* Afin de g�n�rer de l'�nergie, il faudra faire courir le chien sur le tapis pr�sent dans la salle.

 	
###Niveau 3
Le but de ce niveau est d'expliquer la notion de la boucle "for". Le joueur devra construire lui m�me le niveau en faisant appar�tre les objets voulus ( semi sandbox).
Pour le moment il faudra faire tomber tous les dominos � condition que l'algorithme affich�e sur le t�l�visur soit respect�.
La particularit� de ce niveau est l'utilisation d'effets de particules et de textures anim�es.


###Niveau4
Dans ce niveau le joueur devra construire l'algorithme ad�quat afin de faire tomber la s�rie de dominos qu'il devra initialiser au pr�alable, pour ce faire:
* Initialisation en pla�ant les bons cubes dans les bons tiroires de l'armoire rouge (celle de gauche)
* Construction de l'algorithme en pla�ant les bons cubes dans les bons tiroires de l'armoire verte (celle de droite)

En bas de chaque armoire se trouve un bouton "play" qui permet de lancer l'algorithme.


###Niveau5
* Parler au pharaon
* Construire l'algorithme � l'aide des cubes situ�s � l'arri�re de la trappe � gauche de la st�le.
* Solution :
	* Pour K Allant de 0 � TailleZ
	* Pour I Allant de 0 � TailleX
	* Pour J Allant de 0 � TailleY
	* Poser une pierre X-J Y+K Z+I
	* D�cr�menter x2 TailleX
	* D�cr�menter x2 TailleY