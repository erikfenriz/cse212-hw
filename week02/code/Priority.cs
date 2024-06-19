public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Enqueue "A" with priority 1, then Dequeue
        // Expected Result: 
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("A", 1);
        string result = priorityQueue.Dequeue();
        Console.WriteLine(result == "A" ? "Pass" : "Fail");
        Console.WriteLine("---------");

        // Test 2
        // Scenario: Dequeue from an empty queue
        // Expected Result: Display message "The queue is empty." and return null
        Console.WriteLine("Test 2");
        result = priorityQueue.Dequeue();
        Console.WriteLine(result == null ? "Pass" : "Fail");
        Console.WriteLine("---------");

        // Test 3
        // Scenario: Enqueue "A" with priority 1, "B" with priority 3, "C" with priority 2
        // Expected Result: Dequeue should return "B", then "C", then "A"
        Console.WriteLine("Test 3");
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 3);
        priorityQueue.Enqueue("C", 2);
        result = priorityQueue.Dequeue();
        Console.WriteLine(result == "B" ? "Pass" : "Fail");
        result = priorityQueue.Dequeue();
        Console.WriteLine(result == "C" ? "Pass" : "Fail");
        result = priorityQueue.Dequeue();
        Console.WriteLine(result == "A" ? "Pass" : "Fail");
        Console.WriteLine("---------");

        // Test 4
        // Scenario: Enqueue "A" with priority 2, "B" with priority 2, "C" with priority 2
        // Expected Result: returning "A", then "B", then "C"
        Console.WriteLine("Test 4");
        priorityQueue.Enqueue("A", 2);
        priorityQueue.Enqueue("B", 2);
        priorityQueue.Enqueue("C", 2);
        result = priorityQueue.Dequeue();
        Console.WriteLine(result == "A" ? "Pass" : "Fail");
        result = priorityQueue.Dequeue();
        Console.WriteLine(result == "B" ? "Pass" : "Fail");
        result = priorityQueue.Dequeue();
        Console.WriteLine(result == "C" ? "Pass" : "Fail");
        Console.WriteLine("---------");
    }
}