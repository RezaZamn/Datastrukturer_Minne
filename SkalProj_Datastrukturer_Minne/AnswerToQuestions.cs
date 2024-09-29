using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SkalProj_Datastrukturer_Minne
{
    internal class AnswerToQuestions
    {

        /* 1. Hur fungerar stacken och heapen? data sparas i stacken genom en ordning att de staplas på varandra,
        så om vi behöver en viss data och finns data ovan på det så ska de flyttas för att komma åt den specifika data.
        men däremot data läggs utan ordning på heapen, de är utsridda men man kan ha direkt åtkomst till data där. */

        //Klassen Heap är en refres typ och de variablerna som är deklarerade kommer liggas i Heapen.
        public class Heap
        {
            public int NumberInHeap;
            public string StringInHeap;
        }


        //Informationen i stacken kommer att raderas efter körningen av metoden StackMetod
        public string StackMetod(string str)
        {
            return str;
        }



        /* 2. Vad är Value Types respektive Reference Types och vad skiljer dem åt?
        Value types är typer från System.ValuteType som kan ges till olika variabler det med hjälp de som vi kan
        avgöra vilken typ av variabel vi jobbar med. 
        Refrence Type ärver från System.Object, refrence type lagras alltid på heapen med skilnad till value types
        kan både lagras på heapen eller stacken.*/


/* 3. Följande metoder genererar olika svar. Den första returnerar 3, den andra returnerar 4, varför?
   första metoden använder sig av value typen intoch där har man två olika variabler med samma värde dvs. två variabler
   med två olika allokering, så när senare y = tilldelas till 4 så påverkar inte x värdet.

Men i ReturnValue2 metoden används av MyInt som är en refrenstyp och när man sätter y = x så kopieras adressen till objektet
x in i y och det betyder att nu både x och y pekar på samma objekt i heapen, och därför värdet alltid kommer värdet uppdaters
till nya värdet för de både x och y.*/


//----------------------------------------------------------------------------------

/* Övning 1: ExamineList()
 2. När ökar listans kapacitet? Den initiala kapacitet är o från början och den ökar automatiskt
 medan vi lägger till element.

 3. Med hur mycket ökar kapaciteten? den fördubblar sin kapacitet för att kunna hantera flera element.

 4. Varför ökar inte listans kapacitet i samma takt som element läggs till?
 för att undvika ineffektiva omallokeringar.

 5. Minskar kapaciteten när element tas bort ur listan? Nej, det reserverade storleken
  kommer vara samma. Annars listan skulle behöva omallokera sig till en ny array.

 6. När är det då fördelaktigt att använda en egendefinierad array istället för en lista?
 När man vet antalet av element och de inte kommer att förändras.*/


//---------------------------------------------------------------------------------

/*Övning 3
1. Simulera ännu en gång ICA-kön på papper.Denna gång med en stack.Varför är det inte så smart att använda
en stack i det här fallet? För att personen som ställer sig i kön först ska behandlas efter de kommande kunder och det
är inte rättvis och effektiv.*/

//--------------------------------------------------------------------------------

/* Övning 4
Skapa med hjälp av er nya kunskap funktionalitet för att kontrollera en välformad
sträng på papper. Du ska använda dig av någon eller några av de datastrukturer vi
precis gått igenom. Vilken datastruktur använder du?

        Stack har bra egenskap att använda i den här frågan, med hjälp av dess Pop funktion.*/



}
}
