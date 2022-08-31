# Le-Mot-le-plus-long
Jeu en C#  reprenant le jeu le mot le plus long de l'émission Des chiffres et des lettres.
Le but du jeu est de trouver le mot le plus long à partir des lettres proposées.
Il existe plusieurs difficultés qui correspond au nombre d'essais pour trouver le mot le plus long.
Le joueur peut changer de dictionnaire, les dictionnaires correspondent à des thèmes.

Un dictionnaire est en format CSV puis il est utilisé sous forme d'arbre de données par le programme ou chaque noeud représente une lettre.
Lors de la sélection d'un mot au hasard pour une nouvelle partie, le programme prend une branche aléatoire et prend le mot qui correspond ainsi que l'intégralité des autres mots qu'on peut écrire avec les lettres du mot choisi.
