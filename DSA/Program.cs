using DSA.SingleLinkedList;

int choice, data, k, x;
SingleLinkedList list = new SingleLinkedList();

list.CreateList();

while (true)
{
    Console.WriteLine("1. Display List");
    Console.WriteLine("2. Count number of Nodes");
    Console.WriteLine("3. Search for an element in list");

    Console.WriteLine("Enter choice: ");
    choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 19)
        break;

    switch (choice)
    {
        case 1:
            list.DisplayList();
            break;
        case 2:
            list.CountNodes();
            break;
        case 3:
            Console.WriteLine("Enter element to search: ");
            x = Convert.ToInt32(Console.ReadLine());
            list.SearchNode(x);
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}