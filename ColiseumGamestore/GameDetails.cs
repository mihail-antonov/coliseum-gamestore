namespace ColiseumGamestore
{
    using Models;
    using Repositories.DetailRepository;
    using Repositories.GameDetailsRepository;
    using Repositories.GameRepository;
    using System.Linq;
    using System.Windows.Forms;

    public partial class GameDetails : Form
    {
        private readonly IGameDetailsRepository _gameDetailRespository;
        private readonly IGameRepository _gameRepository;
        private readonly IDetailRepository _detailRepository;
        private readonly int _currentId;

        public GameDetails(int currentId)
        {
            _currentId = currentId;
            _gameDetailRespository = (IGameDetailsRepository)StartUp.ServiceProvider.GetService(typeof(IGameDetailsRepository));
            _detailRepository = (IDetailRepository)StartUp.ServiceProvider.GetService(typeof(IDetailRepository));
            _gameRepository = (IGameRepository)StartUp.ServiceProvider.GetService(typeof(IGameRepository));

            InitializeComponent();
            OnStart();
            GetData();
        }

        private void OnStart()
        {
            var detailNames = _detailRepository.GetAllDetails.Select(b => b.Name).ToArray();
            this.ComboDetailId.Items.AddRange(detailNames);
            this.InputGameName.Text = _gameRepository.GetGameById(_currentId).Title;
            GameDetailGrid.ColumnCount = 2;
            GameDetailGrid.Columns[0].Name = "Name";
            GameDetailGrid.Columns[1].Name = "Description";
        }
        private void GetData()
        {
            GameDetailGrid.Rows.Clear();
            var gameDetails = _gameDetailRespository.GetGameDetail(_currentId);
            foreach (var gameDetail in gameDetails)
            {
                string[] currentRow =
                {
                    gameDetail.Detail.Name,
                    gameDetail.Detail.Description,
                };
                GameDetailGrid.Rows.Add(currentRow);
            }
        }

        private void BtnAdd_Click(object sender, System.EventArgs e)
        {
            Detail selectedDetail = _detailRepository.GetDetailByName(ComboDetailId.Text);
            GameDetail currentGameDetail = new GameDetail
            {
                GameId = _currentId,
                DetailId = selectedDetail.Id
            };
            _gameDetailRespository.Add(currentGameDetail);
            GetData();
            MessageBox.Show("Detail successfuly added!");
            ComboDetailId.Text = "";
        }

        private void BtnExit_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Home f1 = new Home();
            f1.ShowDialog();
        }

        private void ComboDetailId_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }
    }
}
