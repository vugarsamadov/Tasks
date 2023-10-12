// 1.  Verilən ədədə və ya ondan böyük ən yaxın ədədə qədər fibonaççi ardıcıllığını ekrana çap edin.

Console.Write("Eded daxil edin: ");
int eded = Convert.ToInt32(Console.ReadLine());

int head = 1;
int tail = -1; 
int temp;
do
{
	Console.Write(head + tail + " ");
	temp = head;
	head = head + tail;
	tail = temp;
}while (eded > head);

// 2. 2 dəyişənin dəyərlərini 3cü dəyişən istifadə etmədən dəyişin.

int a = 6;
int b = 8;

a = a+b;
b = a-b;
a = a-b;



