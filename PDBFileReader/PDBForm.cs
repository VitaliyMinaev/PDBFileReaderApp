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
            string data = null, guid = null, fileType = null;

            await Task.Run(() =>
            {
                data = _pdbFile.GetDataFromPdbFile();
                guid = _pdbFile.TryReadPdbGuid().ToString();
                fileType = _pdbFile.GetFileType();
            });

            pdbFileDateRichTextBox.Text = data;
            pdbGuidTextBox.Text         = guid;
            pdbFileTypeTextBox.Text     = fileType;
        }

        private void chooseFile_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog();
            fileDialog.Title = "Select pdb file";
            fileDialog.InitialDirectory = @"C:\";
            fileDialog.Filter = "(*.pdb) | *.pdb";

            if(fileDialog.ShowDialog() == DialogResult.OK ||
                String.IsNullOrEmpty(fileDialog.FileName) != true)
            {
                _pdbFile = new PDBFile(fileDialog.FileName, 
                    new HexadecimalConverterStrategy());

                var filePath = fileDialog.FileName.Split('\\');
                pathTextBox.Text = filePath[filePath.Length - 1];
            }
        }
    }
}