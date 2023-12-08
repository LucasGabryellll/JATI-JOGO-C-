namespace Person{
  public class Player {
    //Atributos do Player.
    string name;
    int TOTAL_LIFE=100;
    int attack;
    int defense;

    // Contrutor Default, só a vida que está inicializado.
    public Player(){}

    // Contrutor com campos inicializados na criação do objeto.
    public Player(string name, int attack, int defense) {
      this.name=name;
      this.attack=attack;
      this.defense=defense;
    }

    // Método para atacar inimigos.
    public void startAttackEnemy(Enimy enimy) {
      //int attackPerson = this.attack;
      int currentLifeEnimy = enimy.getLife() - attack;

      if(currentLifeEnimy <=0){
        enimy.setLife(0);
      }
      else {
        enimy.setLife(currentLifeEnimy);
      }
    }

    public void defenseAttack(Enimy enimy) {
      int attackEnemy = enimy.getAttack();
      if (defense < attackEnemy) {
        TOTAL_LIFE -= attackEnemy;
       
        if (TOTAL_LIFE < 0) TOTAL_LIFE = 0;
      }
    }

    public void setName(string name) {this.name = name;}
    public string getName() {return name;}

    public void setDefense(int defense) {this.defense = defense;}
    public int getDefense() {return defense;}

    public void setAttack(int attack) {this.attack = attack;}
    public int getAttack() {return attack;}

    public int getLife() {return TOTAL_LIFE;}

  }
}