namespace Person
{
  public class Enimy
  {
    int attack;
    int TOTAL_LIFE = 100;

    public Enimy(int attack) { this.attack = attack; }

    public int getAttack() { return attack; }

    public int getLife() { return TOTAL_LIFE; }

    public int setLife(int life) { return TOTAL_LIFE = life; }
  }
}