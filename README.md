# Projet_POO

## I.	Introduction

Dans le cadre du laboratoire du cours de software engineering 1, il nous a été demandé de réaliser, en groupe, un projet en informatique et plus particulièrement en Programmation Orientée Objet.
Ce projet, c’est un simulateur informatique de réseaux électriques. L’idée est la suivante : on souhaite développer une plateforme capable de simuler un ensemble de producteurs et de consommateurs d’énergie (électrique) dans le but d’optimiser l’impact environnemental ainsi que les achats et reventes d’électricité à l’étranger, faire des simulations de catastrophe et développer des systèmes de régulation automatique du réseau.
De l’autre côté, ce projet permet de mettre en pratique la théorie que nous avons apprise durant le cours, mais aussi de continuellement rechercher des nouvelles informations (sur Internet en général) pour arriver à nos fin. En outre, ce projet de groupe nous pousse à apprendre à travailler à plusieurs et à collaborer/communiquer plus efficacement

## II.	Réalisation du projet

La première étape pour bien commencer ce projet, c’est de réaliser un diagramme de classe et un diagramme de séquence. Le premier nous sera utile pour bien visualiser le modèle statique de notre programme, qui comprend les dépendances entre nos différentes classes ainsi que leurs méthodes et attributs. Le dernier nous permettra de visualiser l’aspect dynamique du programme, càd les interactions entre les différentes classes et la manière dont le processus (ou une étape du processus) va tourner normalement.
Il ne nous reste plus qu’à implémenter ces classes dans un programme. Pour le langage de programmation, nous avons hésité entre C# et Java car il se ressemble assez fort. Finalement, nous avons choisis de coder en C# car on venait d’en apprendre beaucoup en C#, et de surcroît sur la POO, grâce aux cours théoriques.

## III.	Documentation à destination des chercheurs

Commencons par les classes Node, Consommateur et ProducteurEnergie. La classe Node contient deux listes (listconsommateurs et listproducteurs) et plusieurs méthodes permettant d’ajouter un consommateur ou un producteur, de calculer la somme d’énergie consommée et produite, ainsi que de connaitre la quantité d’électricité manquante ou en surplus. Node est reliée a deux classes : Consommateur et ProducteurEnergie (relation d’agrégation).
La classe Consommateur permet de créer un nouveau consommateur (ville ou entreprise), de le connecter sur une ou plusieurs lignes électrique et de pouvoir modifier et observer leur consommation. La classe Consommateur possède aussi une méthode « Alert() » qui indique au système si la consommation d’énergie d’un consommateur est supérieur au maximum d’énergie que les lignes qui la relie peuvent supporter. La classe Node, qui calcule la somme d’énergie consommée, prend en compte l’énergie maximale des consommateurs en fonction du maximum que les lignes peuvent supporter.
Examinons maintenant la classe LigneReseaux. La classe LigneReseaux permet de créer des lignes électriques et de choisir leur puissance max. Chaque ligne est associée à un consommateur.

La classe ProducteurEnergie est une superclasse qui désigne un producteur d’énergie. Les méthodes définies dans cette classe sont des méthodes virtuelles qui seront surchargées dans les classe filles, nos différentes centrales.
Nous avons définis cinq méthodes virtuelles dans cette classe : « SetON() », « SetOFF() », « CoutProduction() », « Emission() », « Production() ».
Ces sous-classes qui héritent de ProducteurEnergie correspondent au différent type de centrale, dont chaque méthode dépend de la météo ou des prix du marché. Par exemple les méthodes « SetON() » ou « SetOFF() » de la classe CentraleNucléaire sont différentes des autres méthodes car elles contiennent un facteur qui, a l’appel de la méthode, va diminuer ou augmenter la production jusqu’au minimum ou maximum.
Un autre exemple est la méthode Production () de la classe CentraleGaz. Si l’ensoleillement est plus grand que 60% et la température est plus élevée que 40°C, la production de la centrale sera divisée par deux car on suppose que la centrale ne sait pas refroidir efficacement ses réacteurs et donc ne pourra tourner que durant la nuit.
Terminons par les classe Météo et FuelMarket. Ces deux classes sont des classes statiques qui ne peuvent donc pas être instanciées. La classe Météo permet de renvoyer trois paramètres : l’ensoleillement, la force du vent et la température grâce à trois méthodes statiques. Météo contient aussi une quatrième méthode « RandomMeteo() » qui change aléatoirement les valeurs des trois variables (ensoleillement, force du vent, température).
La classe FuelMarket fonctionne de la même manière que la classe Météo. Elle renvoie le prix du carbone, de l’uranium, du gaz ainsi que le cout de l’électricité étrangère. Ces quatre montants sont récupérables par quatre méthodes « Get » et une cinquième méthode vide (void) permet d’actualiser aléatoirement la valeur de ces montants.

## IV.	Conclusion
Afin de démontrer le fonctionnement de notre programme, on a utilisé une fenêtre (Windows Form) sur Visual Studio. Nous utilisons trois graphes. Le premier, intitulé Power management, permet de comparer le niveau de production total et de consommation total. Si une surproduction/sous-production survient, l’énergie est vendue/achetée à l’étranger.
Le deuxième, intitulé Market, permet de visualiser le prix du marché des combustibles et le prix à l’achat de l’électricité étrangère.
Le dernier, intitulé Production of energy, montre la production totale de chaque producteur d’énergie, en fonction de la météo.
On retrouve trois labels, qui indique la force du vente (en km/h), l’ensoleillement (en %) et la température (en °C).
Nous avons aussi la possibilité de mettre en route ou à l’arrêt des centrales, grâce au petit menu déroulant et aux boutons ON et OFF.
Enfin, il y a les trois boutons principaux :

*	Start Refreshing, qui permet de lancer la simulation et de l’actualiser toutes les secondes.
* Show producers, qui affiche la liste de tous les producteurs d’énergies, leurs productions max, leurs émissions et leurs couts de production.
* Show consumers, qui affiche la liste de tous les consommateurs d’énergies et leur consommation. Dans cette fenêtre, on affiche aussi les messages d'alertes, dans le cas où un consommateur a besoin de plus d’énergie que ce que ses lignes peuvent supporter.

