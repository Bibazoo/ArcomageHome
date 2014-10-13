namespace Arcomage.Core.Parametrs
{
    /// <summary>
    /// �������� ��������� �����, ��� ��� ����� ��������� ��� �������� ���� ��� ����������
    /// </summary>
    public class CardParametrs 
    {
        public string name { get; set; }
        public int id { get; set; }

        //�������� ����������� � ��������������� ������
        public Buildings playerBuildings { get; set; }
        public SourcesOfResources playerSources { get; set; }
        public Resources playerResources { get; set; }

        //�������� ����������� � ��������������� ����������
        public Buildings enemyBuildings { get; set; }
        public SourcesOfResources enemySources { get; set; }
        public Resources enemyResources { get; set; }

        //��������� ������������� �����
        public Resources cardCost { get; set; }

        public CardParametrs()
        {
            playerBuildings = new Buildings();
            playerSources = new SourcesOfResources();
            playerResources = new Resources();

            enemyBuildings = new Buildings();
            enemySources = new SourcesOfResources();
            enemyResources = new Resources();

            cardCost = new Resources();

            //ArcomageService.ArcoServerClient host = new ArcomageService.ArcoServerClient();
            //var cardFromServer = host.GetRandomCard();

            //CardParametrs newParametrs = JsonConvert.DeserializeObject<CardParametrs>(cardFromServer);
            //name = newParametrs.name;
            //cardCost.Animals = newParametrs.cardCost.Animals;

            //todo: ������� ��������� ���������� � ������ � �������
            /*���� �������� ���������: ���� �� ������ � ��������, � ��� ����������� �������� �����. 
             �������� ������ � �� � ���������� ��������� ����� ������. ������ ������� �� ����� ������ 0.1.0 */
        }
    }
}