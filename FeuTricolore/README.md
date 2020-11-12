# FeuTricolore
## Enoncé :

[![Alt text](https://img.youtube.com/vi/vFns_tJxJbw/mqdefault.jpg)](https://youtu.be/vFns_tJxJbw)

## Temps estimé :
60 minutes
## Objectifs pédagogique :
L'objectif de cet exercice est d'apprendre à utiliser et implémenter un événement.
Contenu de l'exercice :
- Générer un événement par le designer
- Créer son propre événement
- S'abonner à un événement
## Objectifs de l'exercice :
Faire avancer la voiture graphiquement lorsque le feu tricolore et vert, et la stopper dans les autres cas.
![alt text](https://github.com/sybaris-classroom/Exercices/blob/master/FeuTricolore/FeuTricolore.gif)
## Les étapes :
### Etape 1 : 
Afficher un feu tricolore, et qui passe du vert au orange puis au rouge, et reboucle, suivant des durées définies.
Pour cela utiliser un timer qui propose un événement nommé Tick. Abonnez vous à cet événement, et changez de couleur une fois le timer écoulé.
### Etape 2  :
Le feu tricolore doit proposer une événement lorsque le feu change de couleur. Cela évite de boucler (polling) sur l'état du feu.
Un exemple d'implémententation de polling est proposé dans le dossier DemoSansEventPolling. Mais cet exemple est avant tout un contre-exemple car on voit le couplage que cela créé (C.F. constructeur de Voiture) et les problèmes de CPU/Performance, car on boucle sans arret pour lire l'état du feu tricolore.
### Etape 3  :
Et pour finir, quand le feu est vert, il faut démarrer la voiture, sinon l'arreter. C'est utiliser l'événement qui a été créé à l'étape 2. 