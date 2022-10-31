# Digital Factory - Commercialit� Fnac

## Instructions

* Traitez les exos dans l'ordre que vous souhaitez
* Renseignez le fichier *DEVNOTES.md* avec vos questions, remarques, suggestions (Facultatif)
* Bon courage !


## Livrable
* Soit un zip de la solution sans les dossiers *bin* et *obj* (par mail, modifiez l'extension en .zip.txt)
* Soit un lien vers votre repo (github par exemple)



## Evaluation


### 1. Leap

Langage : C# - Dur�e estim�e : 5-10 min

> Enonc� : 
> Votre programme doit d�terminer si l'ann�e pass�e en param�tre est bissextile.
>
> Dans le calendrier gr�gorien une ann�e bissextile respecte les conditions suivantes : 
> Toutes les ann�es qui sont divisibles par 4,
> � l'exception des ann�es qui sont divisibles par 100
> sauf si l'ann�e est ausi divisible par 400.
>
> Par exemple, 1997 n'est pas une ann�e bissextile,
> mais 1996 l'est, 1900 ne l'est pas mais 2000 l'est.



### 2. Refacto

Langage : C# - Dur�e estim�e : 15-20 min

> Enonc� :
> Vous devez refactoriser la m�thode *CalculateDiscount*.



### 3. Calcul

Langage : C# - Dur�e estim�e : 5-10 min

> Enonc� : 
> - V�rifier si les tests unitaires sont ok
> - Corriger les tests unitaires en erreur
> - D�commenter le test *Test_Factorial* et corriger le test
> - Impl�menter les tests associ�s � la m�thode Fraction de *ICalculusServices*
> - Ex�cuter le programme et faites en sorte qu'il n'y'ait pas de soucis � l'ex�cution

### 4. Customer

Language : TSQL - Dur�e estim�e : 15-20 min

> Enonc� :
> A l'aide du fichier *Schema.jpg*, renseignez les scripts suivants :
> - *Script1.sql* : Creation d'une proc�dure stock�e qui renvoie l'ID, le pr�nom et nom du client
>   ainsi que toutes les informations de commandes. En param�tres facultatifs, l'ID du client
>   et l'ID de la commande.
> - *Script2.sql* : Cr�ation d'une proc�dure stock�e permettant de s�lectionner les 5 clients
>   ayant effectu� le plus de commandes un jour donn� (valeur pass�e en param�tre) puis d'ins�rer
>   dans une table de stats, l'ID des clients, le jour sp�cifi� et le nombre de commandes effectu�es.
>   Si la table de stats n'existe pas, il faudra la cr�er.
>   Attention : Pour le mois d'ao�t, aucune stats ne devra �tre enregistr�e.