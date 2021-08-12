package binarysearch;

import java.util.Scanner;

public class BinarySearch {

    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        System.out.print("Enter the length of your number list: ");
        int length = s.nextInt();

        int[] arr = new int[length];
        for (int i = 0; i < length; i++) {
            System.out.print("Enter the value for array index " + i + ": ");
            arr[i] = s.nextInt();
        }

        System.out.print("Enter the value you want to find: ");
        int key = s.nextInt();

        int value = binarySearch(arr, key);

        if (value == -1) {
            System.out.println("Value not found");
        } else {
            System.out.println("Value found at position " + value);
        }
    }

    public static int binarySearch(int[] arr, int key) {
        int start = 0;
        int end = arr.length; 
        while (start <= end) {
            int mid = (start + end) / 2;
            if (key < arr[mid]) {
                end = mid - 1;
            } else if (key > arr[mid]) {
                start = mid + 1;
            } else {
                return (mid+1);
            }
        }
        return -1;
    }

}
