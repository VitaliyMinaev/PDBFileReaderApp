using FileReaderDomain;
using FileReaderDomain.Strategy;

namespace PDBFileReader
{
    public partial class PDBForm : Form
    {
        private PDBFile _pdbFile;
        public PDBForm()
        {
            InitializeComponent();
        }

        private async void loadButton_Click(object sender, EventArgs e)
        {
            try
            {
                dataRichTextBox.Text    = await _pdbFile.GetDataFromPdbFileAsync();
                pdbGuidTextBox.Text     = _pdbFile.TryReadPdbGuid().ToString();
                pdbFileTypeTextBox.Text = await _pdbFile.GetFileTypeAsync();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chooseFile_Click(object sender, EventArgs e)
        {
            try
            {
                var fileDialog = new OpenFileDialog();
                fileDialog.Title = "Select pdb file";
                fileDialog.InitialDirectory = @"C:\";
                fileDialog.Filter = "(*.pdb) | *.pdb";

                if (fileDialog.ShowDialog() == DialogResult.OK ||
                    String.IsNullOrEmpty(fileDialog.FileName) != true)
                {
                    _pdbFile = new PDBFile(fileDialog.FileName,
                        new HexadecimalConverterStrategy());

                    var filePath = fileDialog.FileName.Split('\\');
                    pathTextBox.Text = filePath[filePath.Length - 1];
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", 
                    MessageBoxButtons.CancelTryContinue, MessageBoxIcon.Error);
            }
        }
    }
}