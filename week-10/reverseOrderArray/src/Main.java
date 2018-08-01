public class Main {

    public static void main(String[] args) {

        reverseAnArray();
    }
    public static void reverseAnArray(){
        int[] arrayToReverse = new int[]{1, 3, 6, 11, 2, 5};
        int[] tempArray =  new int[arrayToReverse.length];

        for (int i = 0; i < arrayToReverse.length; i++){
            tempArray[i] = arrayToReverse[arrayToReverse.length - i - 1];
            System.out.println(tempArray[i]);
        }
    }
}
