# AlgorithmsExamples
This is my repository, which will hold all my algorithms created throughout the semester.
## Week 2, Big _O_ types
* Linear Time
* Constant Time
* Quadratic Time

## Week 5 - Fisher-Yates Shuffle
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

     Pseudocode, from NIU
          
           quick_sort(array: data set, start: array[0], end: array[ array.length - 1 ])
                    if start < end
                        pivot_point = partition(array, start, end)
                        quick_sort(array, start, pivot_point - 1)
                        quick_sort(array, pivot_point + 1, end)
                    end if
           end procedure
* Merge
*        Merge uses the divide-and-conquer approach to sorting. Unlike quick sort, merge sort is not
         in-place sorting, meaning we will need extra memory for the sub arrays.
         For the 'divide' aspect, Merge sort calls itself recursively to split the array in half,
         which will split the sub arrays in half until they are one element.
         
         At that point we can compare elements from the the 'left' and 'right' half arrays,
         place those indexes into an array that will be in sorted order, and recursively merge back the 
         arrays until we have 1 sorted array.
         
         Runtime
         Best case:  O(n log n)
         Worst case: O(n log n)

     Pseudocode, from Essential Algorithms
           
           Mergesort(Data: values[], Data: scratch[], Integer: start, Integer: end)
         
            // If the array contains only one item, it is already sorted.
            If (start == end) Then Return
 
                // Break the array into left and right halves.
                Integer: midpoint = (start + end) / 2
 
                // Call Mergesort to sort the two halves.
                Mergesort(values, scratch, start, midpoint)
                Mergesort(values, scratch, midpoint + 1, end)
 
                // Merge the two sorted halves.
                Integer: left_index = start
                Integer: right_index = midpoint + 1
                Integer: scratch_index = left_index
                While ((left_index <= midpoint) And (right_index <= end))
                    If (values[left_index] <= values[right_index]) Then
                        scratch[scratch_index] = values[left_index]
                        left_index = left_index + 1
                    Else
                        scratch[scratch_index] = values[right_index]
                        right_index = right_index + 1
                    End If
                        scratch_index = scratch_index + 1   
                End While
 
                // Finish copying whichever half is not empty.
                For i = left_index To midpoint
                    scratch[scratch_index] = values[i]
                    scratch_index = scratch_index + 1
                Next i
                
                For i = right_index To end
                    scratch[scratch_index] = values[i]
                    scratch_index = scratch_index + 1
                Next i

                // Copy the values back into the original values array.
                For i = start To end
                    values[i] = scratch[i]
                Next i
          End Mergesort
* Heap
*              Heap is a comparison-based sort-in-place sorting algorithm, that means no extra memory is
          required (no extra arrays).
          Similar to seleciton sort, heap sort divides the array into a 'sorted' and 'unsorted' sections.
          
          Heap sort makes use of the 'binary tree structure' (utilizing the parent-child node structure) as it takes an unsorted array and builds
          a 'heap' out of it. This is helpful since the definition of a heap tells us that the parent
          nodes must always be greater than or equal to its child elements. SO when we build a heap, we know that 
          the first element of the array will be the greatest element in the entire array.
          
          When sorting, we swap the FIRST and LAST elements of the heap, 
          placing the greatest element at the end of the array and considering it sorted.
          Since we know the last element is sorted we DON'T want to iterate through it again, now our max index to iterate through is [array.length-i].
          We re-heap the array so that it follows the properties of a heap (the first element may not be > child element)
          We repeat this until we are at index 0, where every element will be sorted.
          
          Runtime
          Best case:  O(n log n)
          Worst case: O(n log n)

Pseudocode, from Essential Algorithms
           
           Heapsort(Data: values)
                
                method: Turn the array into a heap
 
                For i = (values length) - 1 To 0;  Step -1

                    // Swap the root item and the last item.
                    Data: temp = values[0]
                    values[0] = values[i]
                    values[i] = temp
 
                    <Consider the item in position i to be removed from the heap,
                     so the heap now holds i - 1 items. Push the new root value
                     down into the heap to restore the heap property.>
                Next i
            End Heapsort  

## Week 12 - Search Algorithms
This week we looked at different types of sorting algorithms. Here is a project
that goes over Linear Search, Binary Search, and Interpolation Search.
### Interpolate Search
  *      The Interpolate search algorithm works best on sorted data sets 
         that are mostly uniform. Interpolate search uses a formula based off 
         the target value and array size to estimate where the target value's index
         might be located.
         
         The formula goes: LowIndex + (MaxIndex - LowIndex) * (targetValue - array[Lowindex]) / (array[MaxIndex] - array[Lowindex]);
         The algorithm recursivley calls this formula (changing bounds when needed)
         until it finds the index with the target value.
         This algorithm is very efficient compared to the other algorithms on larger data sets;
         You can think of it as trying to find a word in a dictionary and how one determines where the word might be.
         
         Time Complexity
         Best Case: O (log log n)
         Worst Case: O(n)

     Pseudocode
       * Interpolate(array, Low, Max, target)
                        int searchIndex = Low + (Max - Low) * (target - array[Low]) / (array[Max] - array[Low]);

                        if array[searchIndex] = target
                            return index;

                        if array[searchIndex] > target
                            return search(array, Low, searchIndex - 1, target);
            
                        if array[searchIndex] < target
                            return search(array, searchIndex - 1, Max, target);
### Linear Search
  *       The algorithm Linear search is fairly simple, it iterates
          through the entire array until it finds the index with target value.
          This works fine with smaller arrays but not ideal for larger data sets.
          
          Time Complexity
          Best Case: O(1)
          Worst Case: O(n/2)
      Pseudocode
*             for i = array length - 1
                if array[i] = target
                    return index
                else
                    next i;

### Binary Search
*        The Binary search algorithm requires it to have an already sorted
         data set. It checks the middle index of the array/sub-array to see
         if it is the 'target' value.
         
         Initially, we check the middle index of the whole array. If the element
         at the middle index is greater than the target, we check the left half 
         of the array and find the middle index of that half, and recursively do so
         until we have found the target.  - Same for right half if element is initially less than target.
         
         Time Complexity
         Best Case: O(1)
         Worst Case: O(log n)
     Pseudocode
*             function binary_search(array, Low, Hi, target):
                while left <= right:
                    mid = (left + right) // 2
                    if list[mid] == target:
                        return mid
                    elif list[mid] < target:
                        Low = mid + 1
                    else:
                        Hi = mid - 1
                return -1
