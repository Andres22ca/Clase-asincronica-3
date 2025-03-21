using System;

public class ArrayQueue : IQueue
{
    private int[] queue;
    private int front;
    private int rear;
    private int size;

    public ArrayQueue(int size)
    {
        this.size = size;
        queue = new int[size];
        front = -1;
        rear = -1;
    }

    public void Enqueue(int element)
    {
        if (rear == size - 1)
        {
            Console.WriteLine("Queue Overflow");
        }
        else
        {
            if (front == -1)
            {
                front = 0;
            }
            queue[++rear] = element;
        }
    }

    public int Dequeue()
    {
        if (front == -1)
        {
            Console.WriteLine("Queue Underflow");
            return -1;
        }
        else
        {
            int element = queue[front];
            if (front == rear)
            {
                front = -1;
                rear = -1;
            }
            else
            {
                front++;
            }
            return element;
        }
    }

    public int Front()
    {
        if (front == -1)
        {
            Console.WriteLine("Queue Underflow");
            return -1;
        }
        else
        {
            return queue[front];
        }
    }
}

public interface IQueue
{
    void Enqueue(int element);
    int Dequeue();
    int Front();
}



class Program
{
    static void Main(string[] args)
    {
        // Crear una cola con capacidad para 3 elementos
        ArrayQueue queue = new ArrayQueue(3);

        // Prueba 1: Encolar elementos en la cola
        Console.WriteLine("Probando Queue:");
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        queue.Enqueue(40);  // Esto debería generar "Queue Overflow"

        // Verificar el primer elemento de la cola
        Console.WriteLine("Esperado: 10, Obtenido: " + queue.Front());

        // Prueba 2: Desencolar un elemento y verificar el que se elimina
        Console.WriteLine("Dequeue: " + queue.Dequeue());  // Debería mostrar 10
        Console.WriteLine("Esperado: 20, Obtenido: " + queue.Front());  // Debería mostrar 20

        // Prueba 3: Desencolar cuando la cola está vacía
        queue.Dequeue();  // Eliminar 20
        queue.Dequeue();  // Eliminar 30
        Console.WriteLine("Dequeue en cola vacía: " + queue.Dequeue());  // Esto debería generar "Queue Underflow" y retornar -1

        // Prueba 4: Verificar el primer elemento de una cola vacía
        Console.WriteLine("Front en cola vacía: " + queue.Front());  // Esto debería generar "Queue Underflow" y retornar -1
    }
}
