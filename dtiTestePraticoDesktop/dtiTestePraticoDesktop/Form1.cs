using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace dtiTestePraticoDesktop
{
    public partial class Form1 : Form
    {
        private List<Dia> listaLembretes = new List<Dia>();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Configurações iniciais
            dateTimePicker.MinDate = DateTime.Today;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            // Validação dos campos
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("O campo 'Nome' deve estar preenchido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dateTimePicker.Value <= DateTime.Now)
            {
                MessageBox.Show("A data do lembrete deve estar no futuro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Criação do lembrete
            Lembrete lembrete = new Lembrete(txtNome.Text, dateTimePicker.Value);

            // Verifica se o dia já existe na lista de lembretes
            var diaExistente = listaLembretes.FirstOrDefault(d => d.Data.Date == lembrete.Data.Date);
            if (diaExistente != null)
            {
                // Adiciona o lembrete ao dia existente
                diaExistente.Lembretes.Add(lembrete);
            }
            else
            {
                // Cria um novo dia com o lembrete
                listaLembretes.Add(new Dia(lembrete.Data, lembrete));
            }

            // Ordena a lista de lembretes por data
            listaLembretes = listaLembretes.OrderBy(d => d.Data).ToList();

            // Limpa os campos
            txtNome.Text = "";
            dateTimePicker.Value = DateTime.Today;

            // Atualiza a lista de lembretes
            AtualizarListaLembretes();
        }

        private void AtualizarListaLembretes()
        {
            listViewLembretes.Items.Clear();

            foreach (var dia in listaLembretes)
            {
                foreach (var lembrete in dia.Lembretes)
                {
                    var item = new ListViewItem(new[] { dia.Data.ToShortDateString(), lembrete.Nome, txtNome.Text });
                    listViewLembretes.Items.Add(item);
                }
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (listViewLembretes.SelectedItems.Count > 0)
            {
                var itemSelecionado = listViewLembretes.SelectedItems[0];
                var dataLembrete = DateTime.Parse(itemSelecionado.SubItems[0].Text);
                var nomeLembrete = itemSelecionado.SubItems[1].Text;

                // Procura o dia correspondente ao lembrete
                var dia = listaLembretes.FirstOrDefault(d => d.Data.Date == dataLembrete.Date);

                if (dia != null)
                {
                    // Remove o lembrete da lista
                    var lembrete = dia.Lembretes.FirstOrDefault(l => l.Nome == nomeLembrete);
                    dia.Lembretes.Remove(lembrete);

                    // Remove o dia se não houver mais lembretes
                    if (dia.Lembretes.Count == 0)
                    {
                        listaLembretes.Remove(dia);
                    }

                    // Atualiza a lista de lembretes
                    AtualizarListaLembretes();
                }
            }
        }
    }
    public class Lembrete
    {
        public string Nome { get; set; }
        public DateTime Data { get; set; }

        public Lembrete(string nome, DateTime data)
        {
            Nome = nome;
            Data = data;
        }
    }

    public class Dia
    {
        public DateTime Data { get; set; }
        public List<Lembrete> Lembretes { get; set; }

        public Dia(DateTime data, Lembrete lembrete)
        {
            Data = data;
            Lembretes = new List<Lembrete> { lembrete };
        }
    }
}