public class Main {

  public static void main(String[] args) {

    matrixMaker();
  }

  public static int[][] matrixMaker() {

    int[][] matrixCreated = new int[4][4];
    for (int i = 0; i < matrixCreated.length; i++) {
      for (int j = 0; j < matrixCreated.length; j++) {
        if (i == j) {
          System.out.print("1");
        } else {
          System.out.print("0");
        }
      }
      System.out.println();
    }
    return matrixCreated;
  }
}
