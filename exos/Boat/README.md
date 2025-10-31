# Exercice : Création d'objets "Boat" et "Container"

Comme vu dans le document, nous pouvons effectuer des diagrammes de classes.

## Objectif
Créer deux objets de types distincts :
1. **Un objet de type "Boat"**
2. **Un objet de type "Container"**

## Étape 1 : Création d'un objet "Container" et Boat à partir de l'interface 

## Étapes de l'exercice

1. Faire le schéma UML
2. Coder la classe Container
3. Coder la classe Boat

## Étape 2 : Coder trois classes enfants qui héritent de Container: 

Coder les classes nécessaires pour que le code
```csharp
using ExoBoat;

Boat boat = new Boat(22, "Lamoco Cadix", "Tanker");

boat.Containers.Add(new RefrigeratedContainer("x21", 12));
boat.Containers.Add(new RefrigeratedContainer("w451", 12));
boat.Containers.Add(new RefrigeratedContainer("Op44", 12));
boat.Containers.Add(new SensitiveContainer("21re", "Acid"));
boat.Containers.Add(new SensitiveContainer("ggh1", "Petrol"));

Console.WriteLine(boat);
boat.PrintLoad();

Console.ReadKey();
```
Produise le résultat suivant:
```
Le bateau 22 s'appelle Lamoco Cadix, c'est un Tanker
Container x21, température: 12
Container w451, température: 12
Container Op44, température: 12
Container 21re, contient: Acid
Container ggh1, contient: Petrol
```
