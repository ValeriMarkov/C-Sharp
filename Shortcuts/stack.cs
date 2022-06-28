using System;
using System.Collections;

public class SamplesStack{

   public static void Main(){

    //LIFO - last in first out

      Stack newStack = new Stack();
      newStack.Push("Hello ");
      newStack.Push("Viewer ");
      newStack.Push("! ");
      newStack.Push("Just ");
      newStack.Push("Saving ");
      newStack.Push("Stuff ");
      newStack.Push("Here ");
      newStack.Push("! ");
      
      Console.WriteLine("What's in my stack ?");
      Console.WriteLine( "Number of elements: {0}", newStack.Count);
      Console.Write("Elements: ");
      ConsolePrint(newStack);
   }

   public static void ConsolePrint(IEnumerable myCollection){
      foreach(object element in myCollection)
         Console.Write("{0}", element);
   }
}
