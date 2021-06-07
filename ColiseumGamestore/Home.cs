namespace ColiseumGamestore
{
    using Models;
    using Repositories.GameRepository;
    using Repositories.StudioRepository;
    using System.Linq;
    using System.Windows.Forms;

    public partial class Home : Form
    {
        private readonly IGameRepository _gameRepository;
        private readonly IStudioRepository _studioRepository;

        public Home()
        {
            _gameRepository = (IGameRepository)StartUp.ServiceProvider.GetService(typeof(IGameRepository));
            _studioRepository = (IStudioRepository)StartUp.ServiceProvider.GetService(typeof(IStudioRepository));

            InitializeComponent();
            OnStart();
            GetData();
        }

        private void OnStart()
        {
            GameGridView.ColumnCount = 6;
            GameGridView.Columns[0].Name = "Id";
            GameGridView.Columns[1].Name = "Title";
            GameGridView.Columns[2].Name = "Price";
            GameGridView.Columns[3].Name = "Released";
            GameGridView.Columns[4].Name = "Studio";
            GameGridView.Columns[5].Name = "Details";

            var studioNames = _studioRepository.GetAllStudios.Select(b => b.Name).ToArray();
            this.InputStudioId.Items.AddRange(studioNames);
        }

        private void GetData()
        {
            GameGridView.Rows.Clear();
            var gamesStudio = _gameRepository.GetAllGames;
            foreach(Game game in gamesStudio)
            {
                string[] currentRow =
                {
                    game.Id.ToString(),
                    game.Title,
                    game.Price.ToString(),
                    game.Released.ToString(),
                    game.Studio.Name,
                    string.Join(",", game.GameDetails.Select(x => x.Detail.Name))
                };
                GameGridView.Rows.Add(currentRow);
            }
        }

        private void GameGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            InputId.Text = GameGridView.Rows[rowIndex].Cells[0].Value.ToString();
            InputTitle.Text = GameGridView.Rows[rowIndex].Cells[1].Value.ToString();
            InputPrice.Text = GameGridView.Rows[rowIndex].Cells[2].Value.ToString();
            InputReleased.Text = GameGridView.Rows[rowIndex].Cells[3].Value.ToString();
            InputStudioId.Text = GameGridView.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void GameGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int currentId = int.Parse(GameGridView.Rows[rowIndex].Cells[0].Value.ToString());
            this.Hide();
            GameDetails f2 = new GameDetails(currentId);
            f2.ShowDialog();
        }

        private void BtnCreate_Click(object sender, System.EventArgs e)
        {
            Studio selectStudio = _studioRepository.GetAllStudios.SingleOrDefault(b => b.Name == InputStudioId.Text);
            var game = new Game()
            {
                Title = InputTitle.Text,
                Price = int.Parse(InputPrice.Text),
                Released = int.Parse(InputReleased.Text),
                StudioId = selectStudio.Id,
            };
            var gameId =_gameRepository.Add(game);
            ClearForm();
            this.Hide();
            GameDetails f2 = new GameDetails(gameId);
            f2.ShowDialog();
            GetData();
        }

        private void ClearForm()
        {
            InputId.Text = "";
            InputTitle.Text = "";
            InputPrice.Text = "";
            InputReleased.Text = "";
            InputStudioId.Text = "";
        }

        private void BtnUpdate_Click(object sender, System.EventArgs e)
        {
            var game = new Game()
            {
                Id = int.Parse(InputId.Text),
                Title = InputTitle.Text,
                Price = int.Parse(InputPrice.Text),
                Released = int.Parse(InputReleased.Text),
                StudioId = _studioRepository.GetAllStudios.SingleOrDefault(b => b.Name == InputStudioId.Text).Id 
            };

            _gameRepository.Update(game);
            ClearForm();
            GetData();
        }

        private void BtnDelete_Click(object sender, System.EventArgs e)
        {
            var currentId = int.Parse(InputId.Text);
            _gameRepository.Delete(currentId);
            ClearForm();
            GetData();
        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
