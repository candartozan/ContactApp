using ContactApp.Library;

namespace ContactApp.Desktop
{
	public partial class ContactApp : Form
	{
		private ContactDal _contactDal = new ContactDal();

		public ContactApp()
		{
			InitializeComponent();
		}

		private void LoadContacts()
		{
			dgvContacts.DataSource = _contactDal.GetAll();
		}

		private void Search()
		{
			dgvContacts.DataSource = _contactDal.GetByName(tbxSearch.Text);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			LoadContacts();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			_contactDal.Add(new Contact
			{
				Name = tbxName.Text,
				Surname = tbxSurname.Text,
				Number = tbxNumber.Text,
			});
			LoadContacts();
		}

		private void dgvContacts_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			tbxNameUpdate.Text = dgvContacts.CurrentRow.Cells[1].Value.ToString();
			tbxSurnameUpdate.Text = dgvContacts.CurrentRow.Cells[2].Value.ToString();
			tbxNumberUpdate.Text = dgvContacts.CurrentRow.Cells[3].Value.ToString();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			_contactDal.Update(new Contact
			{
				Id = Convert.ToInt32(dgvContacts.CurrentRow.Cells[0].Value),
				Name = tbxNameUpdate.Text,
				Surname = tbxSurnameUpdate.Text,
				Number = tbxNumberUpdate.Text
			});
			LoadContacts();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			_contactDal.Delete(new Contact
			{
				Id = Convert.ToInt32(dgvContacts.CurrentRow.Cells[0].Value),
				Name = tbxNameUpdate.Text,
				Surname = tbxSurnameUpdate.Text,
				Number = tbxNumberUpdate.Text
			});
			LoadContacts();
		}

		private void tbxSearch_TextChanged(object sender, EventArgs e)
		{
			Search();
		}
	}
}