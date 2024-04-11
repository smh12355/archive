public class Account
{
    int sum; // Переменная для хранения суммы
    // через конструктор устанавливается начальная сумма на счете
    public Account(int sum) => this.sum = sum;
    // добавить средства на счет
    public void Add(int sum) => this.sum += sum;
    // взять деньги с счета
    public void Take(int sum)
    {
        // берем деньги, если на счете достаточно средств
        if (this.sum >=sum) this.sum -= sum;
    }
}