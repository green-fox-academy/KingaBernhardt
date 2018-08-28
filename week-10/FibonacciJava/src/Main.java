public class Main {

  public static void main(String[] args) {

    System.out.println(fibonacciMaker(8));
  }

  public static int fibonacciMaker(int n) {
    if (n == 0) {
      return 0;
    } else if (n == 1) {
      return 1;
    } else {
      return fibonacciMaker(n - 1) + fibonacciMaker((n - 2));
    }
  }
}
