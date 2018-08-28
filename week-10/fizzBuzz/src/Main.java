public class Main {

  public static void main(String[] args) {

    fizzBuzzGame();
  }

  public static void fizzBuzzGame() {
    String output = "";
    for (int i = 1; i <= 100; i++) {
      if (i % (5 * 3) == 0) {
        output = "FizzBuzz";
      } else if (i % 5 == 0) {
        output = "Buzz";
      } else if (i % 3 == 0) {
        output = "Fizz";
      } else {
        output = Integer.toString(i);
      }
      System.out.println(output);
    }
  }
}
