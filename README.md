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

## Week 11 - Sorting Algorithms
This week we viewed different sorting algorithms and created them from their Pseudocode.

### Different sorts
* Bubble
*          For bubble sort, we use the fact that 
            if an array is unsorted then there must be adjacent elements
            that are out of order.
           
          We loop through the array and swap adjacent elements that are out of 
           order until there are no more out of order elements.

          Not ideal for large data sets
          
          Runtime
          Best case:  O( n^2 )
          Worst case: O( n^2 )

       Pseudocode, from Essentials Algorithms 
       Bubblesort(Data: values[])
            // Repeat until the array is sorted.

            Boolean: not_sorted = True
            While (not_sorted)

                // Assume we won't find a pair to swap.
                not_sorted = False

                // Search the array for adjacent items that are out of order.
                For i = 0 To <length of values> - 1


                    // See if items i and i - 1 are out of order.
                    If (values[i] < values[i - 1]) Then

                        // Swap them.
                        Data: temp = values[i]
                        values[i] = values[i - 1]
                        values[i - 1] = temp
 
                        // The array isn't sorted after all.
                        not_sorted = True

                    End If
                Next i
            End While
        End Bubblesort  
* Insertion
*         For insertion sort, we iterate through the array and sort in place,
           so no extra storage needed.
          We iterate through the array and then for each index, we check the indices
           that come before the current index to see if there are elements with a value 
          GREATER than the current index.
          (Everything before the current index is considered sorted)
          
          If so, then we 'shift' the previous indices to the next index and 'insert'
          the current index into its correct spot to be sorted.

          Not ideal for large data sets as it must iterate through previous indices for each 'i'.
          
          Runtime
          Best case:  O(n)
          Worst case: O( n^2 )

        Pseudocode, from Essentials Algorithms      
        
         for i=0, i < A.length
          currentIndex = A[i]
          previousIndex = A[i-1]
             While previousIndex > 0 and A[previousIndex] > A[currentIndex] 
                 swap A[previous] and A[currentIndex]
                 previousIndex--; 
             end While
         next i;
* Selection
*         For selection sort, we want to sort the array in ascending order.
          We take the first item in the array as the 'minimum' value. 
          We then iterate to the end and see if there is a lower minimum. If so then swap.
         
          We repeat, but starting with index i+1 each time until we reach the end of the array.

          Not ideal for large data sets for its iteration of each element for every 'i'.
      
          Runtime
          Best case: O(n)
          Worst case: O( n^2 )

       Pseudocode
         
          For i=0, i < A.Length
           Minimum = A[i];
           
             For j=i, j<A.Length
              if A[j] < minimum
                 Minimum = A[j]
                  next j;
            
              swap current index with new Minimum index
           
          next i;
* Quick
*        The way Quick Sort works is that it recursively splits an
         unsorted array into sub-arrays (in place by using pivots), sorting each one.
         An in-place divide-and-conquer strategy to break up and solve smaller sets.
         
         Quick Sort chooses an element to act as a 'pivot' where it 
          uses that value to seperate elements that are greater/less than it,
          usually elements less than to the left of the pivot and items greater than to the right of the pivot.
         Once we have our 2 halves (less than and greater than) we then recurisvely call merge sort to do the same
          steps on the 2 halves. It recurisvely does this until the entire array is sorted.

         Note: There are different methods of choosing the pivot value. Methods can have the pivot be the first element,
         the last element, or even be a random element in the array. For this version, the pivot will be the last value in the array.
         

         Runtime
         Best case:  O(n log n)
         Worst case: O( n^2 )
* Merge
* Heap
