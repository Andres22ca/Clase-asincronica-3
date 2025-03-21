using System;

public class ArrayStack : IStack
{
    private int[] stack;
    private int top;
    private int size;

    public ArrayStack(int size)
    {
        this.size = size;
        stack = new int[size];
        top = -1;
    }

    public void Push(int element)
    {
        if (top == size - 1)
        {
            Console.WriteLine("Stack Overflow");
        }
        else
        {
            stack[++top] = element;
        }
    }

    public int Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack Underflow");
            return -1;
        }
        else
        {
            return stack[top--];
        }
    }

    public int Top()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack Underflow");
            return -1;
        }
        else
        {
            return stack[top];
        }
    }
}

public interface IStack
{
    void Push(int element);
    int Pop();
    int Top();
}




class Program
{
    static void Main(string[] args)
{
    // Crear una pila con capacidad para 3 elementos
    ArrayStack stack = new ArrayStack(3);

    // Prueba 1: Agregar elementos a la pila
    Console.WriteLine("Probando Stack:");
    stack.Push(10);
    stack.Push(20);
    stack.Push(30);
    stack.Push(40);  // Esto debería generar "Stack Overflow"

    // Verificar el elemento en la cima
    Console.WriteLine("Esperado: 30, Obtenido: " + stack.Top());

    // Prueba 2: Hacer un Pop y verificar el elemento que se elimina
    Console.WriteLine("Pop: " + stack.Pop());  // Debería mostrar 30
    Console.WriteLine("Esperado: 20, Obtenido: " + stack.Top());  // Debería mostrar 20

    // Prueba 3: Hacer un Pop cuando la pila está vacía
    stack.Pop();  // Eliminar 20
    stack.Pop();  // Eliminar 10
    Console.WriteLine("Pop en pila vacía: " + stack.Pop());  // Esto debería generar "Stack Underflow" y retornar -1

    // Prueba 4: Verificar la cima de una pila vacía
    Console.WriteLine("Top en pila vacía: " + stack.Top());  // Esto debería generar "Stack Underflow" y retornar -1
}
}