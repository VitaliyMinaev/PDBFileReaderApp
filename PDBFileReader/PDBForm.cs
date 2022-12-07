using FileReaderDomain;
using FileReaderDomain.Strategy;
using FileReaderDomain.Strategy.Abstract;

namespace PDBFileReader
{
    public partial class PDBForm : Form
    {
        private IConverterStraregy _converterStrategy;
        private string _filename;
        public PDBForm()
        {
            InitializeComponent();
            SetHexadecimalConverterStrategy();
        }

        private void SetHexadecimalConverterStrategy()
        {
            hexadecimalToolStripMenuItem.Checked = true;
            _converterStrategy = new HexadecimalConverterStrategy();

            decimalToolStripMenuItem.Checked = false;
        }
        private void SetBytesConverterStrategy()
        {
            decimalToolStripMenuItem.Checked = true;
            _converterStrategy = new BytesConverterStratagy();

            hexadecimalToolStripMenuItem.Checked = false;
        }

        private async void loadButton_Click(object sender, EventArgs e)
        {
            try
            {
                var pdbFile = new PDBFile(_filename, _converterStrategy);

                byte[] data = await pdbFile.GetDataFromPdbFileAsync();

                decodedAsciiRichTextBox.Text    = await pdbFile.GetStringFromASCII(data);
                dataRichTextBox.Text            = await pdbFile.ConvertBytesToString(data);
                pdbGuidTextBox.Text             = pdbFile.TryReadPdbGuid().ToString();
                pdbFileTypeTextBox.Text         = await pdbFile.GetFileTypeAsync();
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
                    _filename = fileDialog.FileName;

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

        private void chooseFormatToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.UpdateStatus(e.ClickedItem);
        }

        private void UpdateStatus(ToolStripItem item)
        {
            if (item != null)
            {
                if(item.Text == "Bytes")
                {
                    SetBytesConverterStrategy();
                }
                else if(item.Text == "Hexadecimal")
                {
                    SetHexadecimalConverterStrategy();
                }
            }
        }
    }
}