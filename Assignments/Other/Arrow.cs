using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//namespace The_C__player_s_guide.Assignments.Other
//{
//    internal class Arrow
//    {
//        public Arrow() { }

//        public void RunArrow() 
//        { 
//            new Arrow().RunArrow(); 
//        }
//    }
//}
enum ArrowHead { Steel, Wood, Obsidian }
enum FletchingType { Plastic, TurkeyFeather, GooseFeather }

class Arrow
{
    // Global variabler som ligger innanför class Arrow som kan nås från metoder.
    //underscore _ är ett förtydligande0
    private int _length;
    private ArrowHead _arrowHeadType;
    private FletchingType _fletchingType;
    
    public void RunArrow() 
    {
        WhatArrow();
    }

    // constructor, en klass starting state med default värden 
    public Arrow(int length, ArrowHead arrowHeadType, FletchingType fletchingType)
    {
        _length = length;
        _arrowHeadType = arrowHeadType;
        _fletchingType = fletchingType;
    }

    /*Metod GetArrowHeadPrice som innehåller switch på _arrowHeadType, där användaren får
     välja vilken typ av huvud som används på pilen, samt returnerar vilket värde varje pilhuvud
    är*/
    private int GetArrowHeadPrice()
    {
        switch (_arrowHeadType) // Kommer från constructor Arrow
        {
            case ArrowHead.Steel: return 10; // Kommer från enum ArrowHead samt return värde
            case ArrowHead.Wood: return 3;
            case ArrowHead.Obsidian: return 5;
            default: return 0;
        }

    }
    private int GetFletchingPrice()
    {

        switch (_fletchingType) // Kommer från constructor Arrow
        {
            case FletchingType.Plastic: return 10; // Kommer från enum FletchingType samt return värde
            case FletchingType.TurkeyFeather: return 5;
            case FletchingType.GooseFeather: return 3;
            default: return 0;
        }

    }
    /*Metoden GetCost beräknar priset på hur mycket pilen kommer kosta
     med hjälp utav metoderna GetArrowHeadPrice, GetFletchingPrice samt längden
    totalSum är det som åker in i var cost = arrow.GetCost()*/
    public float GetCost()
    {

        float length = 0.05f * _length;

        int arrowHeadPrice = GetArrowHeadPrice();
        int fletchPrice = GetFletchingPrice();
        float totalSum = arrowHeadPrice + fletchPrice + length;
        return totalSum;
    }
    public void WhatArrow() 
    {
        Console.WriteLine("What kind of arrow head do you want? You can choose between: ");
        Console.WriteLine("1. Steel");
        Console.WriteLine("2. Wood");
        Console.WriteLine("3. Obsidian");
        int userInputArrowHead = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("What kind of fletching type do you want? You can choose between: ");
        Console.WriteLine("1. Plastic");
        Console.WriteLine("2. Turkey feathers");
        Console.WriteLine("3. Goose feathers");
        int userInputFletching = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("What length do you prefer for the arrow? Length must be between 60 - 100 cm.");
        Console.Write("Arrow length: ");
        int arrowLength = int.Parse(Console.ReadLine());

        while (arrowLength < 59 || arrowLength > 100)
        {
            Console.WriteLine("That is not an correct length for an arrow, please try again!");
            Console.Write("New length: ");
            arrowLength = int.Parse(Console.ReadLine());
        }


        ArrowHead arrowType = 0;
        FletchingType fletchingType = 0;

        switch (userInputArrowHead)
        {
            case 1:
                arrowType = ArrowHead.Steel;
                break;
            case 2:
                arrowType = ArrowHead.Wood;
                break;
            case 3:
                arrowType = ArrowHead.Obsidian;
                break;
            default:
                Console.WriteLine("Wrong item.");
                break;
        }

        switch (userInputFletching)
        {

            case 1:
                fletchingType = FletchingType.Plastic;
                break;
            case 2:
                fletchingType = FletchingType.TurkeyFeather;
                break;
            case 3:
                fletchingType = FletchingType.GooseFeather;
                break;
            default:
                Console.WriteLine("Wrong item.");
                break;
        }

        var arrow = new Arrow(arrowLength, arrowType, fletchingType);
        var cost = arrow.GetCost();
        Console.WriteLine($"Your arrow head is: {arrowType}, the fletching type is: {fletchingType}\nand the total cost is: {cost} gold.");
    }
}





