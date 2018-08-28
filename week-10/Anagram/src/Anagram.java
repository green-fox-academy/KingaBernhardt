import java.lang.reflect.Array;
import java.util.Arrays;
import java.util.Scanner;

public class Anagram {

  public static void main(String[] args) {
    Scanner firstInput = new Scanner(System.in);
    System.out.println("Please give me a word");
    String input1 = firstInput.next();

    Scanner secInput = new Scanner(System.in);
    System.out.println("Please give me an other word");
    String input2 = secInput.next();

    System.out.println(anagramChecker(input1, input2));

  }

  public static boolean anagramChecker(String firstInput, String secondInput) {

    char[] firstInputArray = firstInput.toCharArray();
    char[] secondInputArray = secondInput.toCharArray();
    if (firstInputArray.length != secondInputArray.length) {
      return false;

    } else {
      Arrays.sort(firstInputArray);
      Arrays.sort(secondInputArray);
      return Arrays.equals(firstInputArray, secondInputArray);
    }
  }
}
