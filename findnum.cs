 int[] arr = { 23, 56, 67, 78, 89, 90, 94, 95, 96, 97, 99 };
 int key = 97;
 int minNum = 0;
 int maxNum = arr.Length - 1;
 while (minNum <= maxNum)
 {
 int mid = (minNum + maxNum) / 2;
 if (key == arr[mid])
 {
 ++mid;
 break;
 }
 else if (key<arr[mid])
 {
            maxNum = mid - 1;
 }
 else
 {
            minNum = mid + 1;
 }
 }
