# FeuTricolore
L'objectif de cet exercice est d'apprendre à utiliser et implémenter un événement.
Pour cela il y a 3 étapes :

## Etape 1 : 
Afficher un feu tricolore, et qui passe du vert au orange puis au rouge, et reboucle, suivant des durées définies.
Pour cela utiliser un timer qui propose un événement nommé Tick. Abonnez vous à cet événement, et changez de couleur une fois le timer écoulé.
## Etape 2  :
Le feu tricolore doit proposer une événement lorsque le feu change de couleur. Cela évite de boucler (polling) sur l'état du feu.
Un exemple d'implémententation de polling est proposé dans le dossier DemoSansEventPolling. Mais cet exemple est avant tout un contre-exemple car on voit le couplage que cela créé (C.F. constructeur de Voiture) et les problèmes de CPU/Performance, car on boucle sans arret pour lire l'état du feu tricolore.
## Etape 3  :
Et pour finir, quand le feu est vert, il faut démarrer la voiture, sinon l'arreter. C'est utiliser l'événement qui a été créé à l'étape 2. 

## Les dossiers :
Dans le dossier starter, vous trouverez un projet qui compile avec des TODO à implémenter.
Dans le dossier solution, vous trouverez la solution de l'exercice. Je vous invite à l'exécuter (sans lire le code de la solution) pour voir le résultat final attendu.