# AlgorithmsExamples
This is my repository, which will hold all my algorithms created throughout the semester.
## Week 2, Big _O_ types
* Linear Time
* Constant Time
* Quadratic Time

## Week 5 - Current, Fisher-Yates Shuffle
This week we looked at numerical algorithms, one of which was the Fisher-Yates Shuffle.
The Fisher-Yates algorithm iterates through an array in reverse by starting at the last element.  

We pick an random element (0 to n-1), and then swap it with the current index.
Our current index is now n-1 which is what we bound our random number's MAX to. We repeat this process
until we reach element 0.

Within 'FileImportToShuffle' is an example of the Fisher-Yates Shuffle

## Week 8 - Data Structures
This week we explored different types of data structures such as Hash tables, Arrays, Queues and Stacks

### Key notes about the data structures

            HASH TABLES
            
            PRO: They better suited for larger data sets as inserting, lookup and delete
            take on average O(1) to compute, worst case O(n).
            
            CON: When two keys lead to the same bucket (a collision) linked lists are used to search 
            for the desired items, which is not ideal for large data sets.
           

            ARRAY
            
            PRO: Arrays are great for small data sets. Initializing an array keeps all the elements near
            eachother in memory which allows for quick and efficient lookup. 
            Insert takes O(1), lookup and delete takes O(n).
            
            CONS: The lookup taking O(n) makes arrays not ideal for large data sets, whereas Hash points you 
            directly to the data location.
            

            STACK
            
            PRO: All operations take O(1) to perform.
            
            Stacks have a LIFO proerty (Last In First Out), where the LAST item to enter the stack
            is the FIRST item to leave the stack. 
             
            Stacks can be used for tracking data through a process. An example can be
            the 'Undo' command in a lot of software. You can 'Pop' off the last command 
            and return to the previous iteration.
            
            CONS: If you need to access something at the bottom of the stack, it would take O(n) time
            and would be inefficient.
            

            QUEUE
            
            PRO: Very similar to Stacks, all operations take O(1) time to perform.
            
            Queues, unlike stacks, follow the FIFO method (First In First Out).
            The First item to enter the queue is the First item to leave the queue.
            
            An example use could be handling web requests, where you would want to handle them in the order
            that they were recieved.
            
            CONS: There is no random access, so searching for where an item is or if it contains an item
            is not ideal with Queues as you would need to convert to an array.
