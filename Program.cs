/*
Challenge 1. Given a jagged array of integers (two dimensions).
Find the common elements in the nested arrays.
Example: int[][] arr = { new int[] {1, 2}, new int[] {2, 1, 5}}
Expected result: int[] {1,2} since 1 and 2 are both available in sub arrays.
*/

using System;
using System.Text;

int[] CommonItems(int[][] jaggedArray)
{
   List<int> commonElements=new List<int>();
foreach (int rowOneValue in jaggedArray[0]) {
    foreach(int rowTwoValue in jaggedArray[1])
if(rowOneValue==rowTwoValue){
  commonElements.Add(rowOneValue);
}
}
return commonElements.ToArray();
}
int[][] arr1 = { new int[] { 1, 2 }, new int[] { 2, 1, 5 } };
 int[] arr1Common = CommonItems(arr1);
 Console.WriteLine("Common Elements:");
 foreach (int element in arr1Common)
{
    Console.WriteLine(element);
}


/* 
Challenge 2. Inverse the elements of a jagged array.
For example, int[][] arr = {new int[] {1,2}, new int[]{1,2,3}} 
Expected result: int[][] arr = {new int[]{2, 1}, new int[]{3, 2, 1}}
*/
void InverseJagged(ref int[][] jaggedArray )
{
for(int i=0;i<jaggedArray.Length;i++){
for(int j=0;j<jaggedArray[i].Length-1;j++){
int temp=jaggedArray[i][j];
jaggedArray[i][j]=jaggedArray[i][jaggedArray[i].Length-j-1];
jaggedArray[i][jaggedArray[i].Length-j-1]=temp;
}
}
}
int[][] arr2 = { new int[] { 1, 2 }, new int[] { 1, 2, 3 } };
InverseJagged(ref arr2);
/* write method to print arr2 */
for(int i=0;i<arr2.Length;i++){
    Console.WriteLine("swapped array");
for(int j=0;j<arr2[i].Length;j++)
{
    Console.WriteLine(arr2[i][j]);
}
}

int[][] arr = { new int[] { 1, 2 }, new int[] { 1, 2, 3 } };
InverseJagged(ref arr);
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine("revered array");
    for (int j = 0; j < arr[i].Length; j++)
    {
        Console.WriteLine(arr[i][j]);
    }
}

/* 
Challenge 3.Find the difference between 2 consecutive elements of an array.
For example, int[][] arr = {new int[] {1,2}, new int[]{1,2,3}} 
Expected result: int[][] arr = {new int[] {-1}, new int[]{-1, -1}}
 */
void CalculateDiff(ref int[][] jaggedArray)
{

    for(int i=0;i<jaggedArray.Length;i++){
        for(int j=0;j<jaggedArray[i].Length-1;j++){
            jaggedArray[i][j]= jaggedArray[i][j]-jaggedArray[i][j+1];
        }
        Array.Resize(ref jaggedArray[i], jaggedArray[i].Length - 1); 
}
}
int[][] arr3 = { new int[] { 1, 2 }, new int[] { 1, 2, 3 } };
CalculateDiff(ref arr3);
/* write method to print arr3 */
for (int i = 0; i < arr3.Length; i++)
{
    Console.WriteLine("subtracted array");
    for (int j = 0; j < arr3[i].Length; j++)
    {
        Console.WriteLine(arr3[i][j]);
    }
     Console.WriteLine();
}

/* 
Challenge 4. Inverse column/row of a rectangular array.
For example, given: int[,] arr = {{1,2,3}, {4,5,6}}
Expected result: {{1,4},{2,5},{3,6}}
 */
int[,] InverseRec(int[,] recArray)
{
   int[,] newRecArray=new int[recArray.GetLength(1),recArray.GetLength(0)];
for(int i=0;i<recArray.GetLength(1);i++){
    for(int j=0;j<recArray.GetLength(0);j++){
        newRecArray[i,j]=recArray[j,i];
    }                                                                          
}
return newRecArray;
}

int[,] arr4 = { { 1, 2, 3 }, { 4, 5, 6 } };
int[,] arr4Inverse = InverseRec(arr4);
for(int i=0;i<arr4Inverse.GetLength(0);i++){
     Console.WriteLine("row inverted into column");
    for(int j=0;j<arr4Inverse.GetLength(1);j++){
        Console.WriteLine(arr4Inverse[i,j]);
    }
    Console.WriteLine();
}


/*Challenge 5. Write a function that accepts a variable number of params of any of these types: 
string, number. 
- For strings, join them in a sentence. 
- For numbers then sum them up. 
- Finally print everything out. 
Example: Demo("hello", 1, 2, "world") 
Expected result: hello world; 3 */
void Demo(params object[] items)
{
    int sum=0;
     var sentence = new StringBuilder();
    foreach(object item in items){
   if(item is string str){
sentence.Append(str).Append(" ");
   }
   if(item is int num){
    sum=sum+num;
   }
    }
   var AnotherGreet = string.Format(" \"{0}; {1} \" ", sentence, sum);
    Console.WriteLine(AnotherGreet);

}
Demo("hello", 1, 2, "world"); //should print out "hello world; 3"
Demo("My", 2, 3, "daughter", true, "is");//should print put "My daughter is; 5"


/* Challenge 6. Write a function to swap 2 objects but only if they are of the same type 
and if they’re string, lengths have to be more than 5. 
If they’re numbers, they have to be more than 18. */
void SwapTwo(object obj1,object obj2)
{
    if(obj1.GetType()!=obj2.GetType()){
        Console.WriteLine("the types of objects are not same");
    }
       else if(obj1 is int){
             int n1 = Convert.ToInt32(obj1);
          int n2 = Convert.ToInt32(obj2);
            if(n1>18&&n2>18){
                object temp=obj1;
                obj1=obj2;
                obj2=temp;
                Console.WriteLine($"{obj1}  {obj2}");
            }
                 else{
                Console.WriteLine("the figure is less than 18");
            }
            }
    else if(obj1 is string){
             string str1 = (string)obj1;
             string str2 = (string)obj2;
            if(str1.Length>5&&str2.Length>5){
                object temp=obj1;
                obj1=obj2;
                obj2=temp;
                Console.WriteLine($"{obj1}  {obj2}");
            }
            
            else{
                Console.WriteLine("the length is not more than 5");
            }

    }
    else{
        Console.WriteLine("the objects are of not type string");
    }
}
string string1="mother";
string string2="father";
SwapTwo(string1,string2);
SwapTwo("web","development");
SwapTwo(4,12);
SwapTwo("Hiba",12);




/* Challenge 7. Write a function that does the guessing game. 
The function will think of a random integer number (lets say within 100) 
and ask the user to input a guess. 
It’ll repeat the asking until the user puts the correct answer. */
void GuessingGame()
{
Random random=new Random();
int userInput;
 int randomNumber = random.Next(1, 100);
do{
        Console.WriteLine("Enter your guess(1-100)");
         userInput = Convert.ToInt32(Console.ReadLine());
 } while(randomNumber!=userInput);
 Console.WriteLine("your made the right guess");
}
GuessingGame();

/* Challenge 8. Provide class Product, OrderItem, Cart, which make a feature of a store
Complete the required features in OrderItem and Cart, so that the test codes are error-free */

var product1 = new Product(1, 30);
var product2 = new Product(2, 50);
var product3 = new Product(3, 40);
var product4 = new Product(4, 35);
var product5 = new Product(5, 75);

var orderItem1 = new OrderItem(product1, 2);
var orderItem2 = new OrderItem(product2, 1);
var orderItem3 = new OrderItem(product3, 3);
var orderItem4 = new OrderItem(product4, 2);
var orderItem5 = new OrderItem(product5, 5);
var orderItem6 = new OrderItem(product2, 2);

// var cart = new Cart();
// cart.AddToCart(orderItem1, orderItem2, orderItem3, orderItem4, orderItem5, orderItem6);

// //get 1st item in cart
// var firstItem = cart[0];
// Console.WriteLine(firstItem);

// //Get cart info
// cart.GetCartInfo(out int totalPrice, out int totalQuantity);
// Console.WriteLine("Total Quantity: {0}, Total Price: {1}", totalQuantity, totalPrice);

// //get sub array from a range
// var subCart = cart[1, 3];
// Console.WriteLine(subCart);

class Product
{
    public int Id { get; set; }
    public int Price { get; set; }

    public Product(int id, int price)
    {
        this.Id = id;
        this.Price = price;
    }
}

class OrderItem : Product
{
    public int Quantity { get; set; }

    public OrderItem(Product product, int quantity) : base(product.Id, product.Price)
    {
        this.Quantity = quantity;
    }

    /* Override ToString() method so the item can be printed out conveniently with Id, Price, and Quantity */
}

class Cart
{
    private List<OrderItem> _cart { get; set; } = new List<OrderItem>();

    /* Write indexer property to get nth item from _cart */

    /* Write indexer property to get items of a range from _cart */

    public void AddToCart(params OrderItem[] items)
    {
        /* this method should check if each item exists --> increase value / or else, add item to cart */
    }
    /* Write another method called Index */

    /* Write another method called GetCartInfo(), which out put 2 values: 
    total price, total products in cart*/

    /* Override ToString() method so Console.WriteLine(cart) can print
    id, unit price, unit quantity of each item*/

}