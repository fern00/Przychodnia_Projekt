﻿using Przychodnia.DAL.Repozytoria;
using System;
using System.Windows;
namespace Przychodnia.Functions
{

    public partial class AppointmentForm : Window
    {
        public delegate void DataChangedEventHandler(object sender, EventArgs e);

        public event DataChangedEventHandler DataChanged;

        public AppointmentForm()
        {
            InitializeComponent();
            ComboBoxFill();
            FunctionName.Content = "Dodaj wizytę";
            ID_wizytyTextBox.Text = (Lists.Appointments[Lists.Appointments.Count - 1].ID_wizyty  + 1).ToString();
            ID_wizytyTextBox.IsReadOnly = true;

        }
        public AppointmentForm(int index)
        {
            InitializeComponent();
            FunctionName.Content = "Edytuj wizytę";
            ComboBoxFill();
            ID_wizytyTextBox.IsReadOnly = true;
            ID_wizytyTextBox.Text = Lists.Appointments[index].ID_wizyty.ToString();
            PESEL_Combobox.SelectedItem = Lists.Appointments[index].PESEL.ToString();
            NrSaliComboBox.SelectedItem = Lists.Appointments[index].Numer_sali;
            IdLekarzaComboBox.SelectedItem = Lists.Appointments[index].ID_lekarza;
            DataWizytyCombobox.SelectedItem = Lists.Appointments[index].Data_wizyty;
            GodzWizytyComboBox.SelectedItem = Lists.Appointments[index].Godzina_wizyty.ToString();
            RodzajWizytyComboBox.SelectedItem = Lists.Appointments[index].Rodzaj_wizyty.ToString();
            OpisTextBox.Text = Lists.Appointments[index].Opis_dolegliwosci.ToString();
            ChorobaTextBox.Text = Lists.Appointments[index].Choroba.ToString();
            LeczenieTextBox.Text = Lists.Appointments[index].Leczenie.ToString();
            ZwolnienieTextBox.Text = Lists.Appointments[index].Zwolnienie.ToString();

        }
        private void XButtonClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void ComboBoxFill()
        {
            foreach (var item in Lists.Patients)
                PESEL_Combobox.Items.Add(item.PESEL);

            foreach (var item in Lists.Rooms)
                NrSaliComboBox.Items.Add(item.Numer_sali);
            
            foreach (var item in Lists.Doctors)
                IdLekarzaComboBox.Items.Add(item.ID_lekarza);

            GodzWizytyComboBox.Items.Add("08:00:00");
            GodzWizytyComboBox.Items.Add("08:30:00");
            GodzWizytyComboBox.Items.Add("09:00:00");
            GodzWizytyComboBox.Items.Add("09:30:00");
            GodzWizytyComboBox.Items.Add("10:00:00");
            GodzWizytyComboBox.Items.Add("10:30:00");
            GodzWizytyComboBox.Items.Add("11:00:00");
            GodzWizytyComboBox.Items.Add("11:30:00");
            GodzWizytyComboBox.Items.Add("12:00:00");
            GodzWizytyComboBox.Items.Add("12:30:00");
            GodzWizytyComboBox.Items.Add("13:00:00");
            GodzWizytyComboBox.Items.Add("13:30:00");
            GodzWizytyComboBox.Items.Add("14:00:00");
            GodzWizytyComboBox.Items.Add("14:30:00");
            GodzWizytyComboBox.Items.Add("15:00:00");
            GodzWizytyComboBox.Items.Add("15:30:00");
            GodzWizytyComboBox.Items.Add("16:00:00");
            GodzWizytyComboBox.Items.Add("16:30:00");
            GodzWizytyComboBox.Items.Add("17:00:00");


            for (int i = 1; i < 10; i++)
                DataWizytyCombobox.Items.Add("0"+i+".07.2020");
                

            for (int i = 10; i < 31; i++)
                DataWizytyCombobox.Items.Add( i + ".07.2020");
                

            RodzajWizytyComboBox.Items.Add("Kontrolna");
            RodzajWizytyComboBox.Items.Add("Zabieg");
            RodzajWizytyComboBox.Items.Add("Konsultacja");
            RodzajWizytyComboBox.Items.Add("Badanie");
        }
        private void SaveAppointmentButtonClick(object sender, RoutedEventArgs e)
        {
            if (ID_wizytyTextBox.Text == "")
                MessageBox.Show("Pole ID Wizyty jest puste!");
            else if(PESEL_Combobox.SelectedIndex == -1)
                MessageBox.Show("Pole PESEL nie zostało wybrane!");
            else if (NrSaliComboBox.SelectedIndex == -1)
                MessageBox.Show("Pole Nr sali nie zostało wybrane!");
            else if (IdLekarzaComboBox.SelectedIndex == -1)
                MessageBox.Show("Pole Id lekarza nie zostało wybrane!");
            else if (DataWizytyCombobox.SelectedIndex == -1)
                MessageBox.Show("Pole Data wizyty nie zostało wybrane!");
            else if (GodzWizytyComboBox.SelectedIndex == -1)
                MessageBox.Show("Pole Godzina wizyty nie zostało wybrane!");
            else if (RodzajWizytyComboBox.SelectedIndex == -1)
                MessageBox.Show("Pole Rodzaj wizyty nie zostało wybrane!");
            else if (OpisTextBox.Text == "")
                MessageBox.Show("Pole Opis objawów nie zostało wybrane!");
            else if (OpisTextBox.Text == "")
                MessageBox.Show("Pole Opis objawów nie zostało wybrane!");
            else if (OpisTextBox.Text == "")
                MessageBox.Show("Pole Opis objawów nie zostało wybrane!");
            else if (RoomCheck(ID_wizytyTextBox.Text.ToString(), NrSaliComboBox.SelectedItem.ToString(), DataWizytyCombobox.SelectedItem.ToString(), GodzWizytyComboBox.SelectedItem.ToString()) == true)
                MessageBox.Show("Sala w tym terminie jest już zajęta!");
            else if (DoctorCheck(ID_wizytyTextBox.Text.ToString(), IdLekarzaComboBox.SelectedItem.ToString(), DataWizytyCombobox.SelectedItem.ToString(), GodzWizytyComboBox.SelectedItem.ToString()) == true)
                MessageBox.Show("Lekarz w tym terminie jest już zajęty!");
            else if (PatientCheck(ID_wizytyTextBox.Text.ToString(), PESEL_Combobox.SelectedItem.ToString(), DataWizytyCombobox.SelectedItem.ToString(), GodzWizytyComboBox.SelectedItem.ToString()) == true)
                MessageBox.Show("Pacjent w tym terminie jest już zajęty!");
            else
            {
                if (FunctionName.Content.ToString() == "Dodaj wizytę")
                {
                    AppointmentRepo.AddNewAppointment(ID_wizytyTextBox.Text.ToString(), PESEL_Combobox.SelectedItem.ToString(),IdLekarzaComboBox.SelectedItem.ToString(), NrSaliComboBox.SelectedItem.ToString(), RodzajWizytyComboBox.SelectedItem.ToString(), 
                        OpisTextBox.Text.ToString(), DataWizytyCombobox.SelectedItem.ToString(), GodzWizytyComboBox.SelectedItem.ToString(), ChorobaTextBox.Text.ToString(), LeczenieTextBox.Text.ToString(), ZwolnienieTextBox.Text.ToString());
                    
                    DataChangedEventHandler handler = DataChanged;
                    if (handler != null)
                        handler(this, new EventArgs());

                    this.Close();
                }
                if (FunctionName.Content.ToString() == "Edytuj wizytę")
                {
                    AppointmentRepo.EditAppointment(ID_wizytyTextBox.Text.ToString(), PESEL_Combobox.SelectedItem.ToString(), IdLekarzaComboBox.SelectedItem.ToString(), NrSaliComboBox.SelectedItem.ToString(), RodzajWizytyComboBox.SelectedItem.ToString(),
                        OpisTextBox.Text.ToString(), DataWizytyCombobox.SelectedItem.ToString(), GodzWizytyComboBox.SelectedItem.ToString(), ChorobaTextBox.Text.ToString(), LeczenieTextBox.Text.ToString(), ZwolnienieTextBox.Text.ToString());
                    
                    DataChangedEventHandler handler = DataChanged;
                    if (handler != null)
                        handler(this, new EventArgs());

                    this.Close();
                }
            }
        }
        private bool RoomCheck(string id, string nrsali, string data, string godzina)
        {
            foreach (var item in Lists.Appointments)
                if (item.Numer_sali.ToString() == nrsali & item.Data_wizyty == data & item.Godzina_wizyty == godzina & item.ID_wizyty.ToString() != id)
                    return true;
            return false;
        }
        private bool PatientCheck(string id, string pesel, string data, string godzina)
        {
            foreach (var item in Lists.Appointments)
                if (item.PESEL.ToString() == pesel & item.Data_wizyty == data & item.Godzina_wizyty == godzina & item.ID_wizyty.ToString() != id)
                    return true;
            return false;
        }

        private bool DoctorCheck(string id, string lekarz, string data, string godzina)
        {
            foreach (var item in Lists.Appointments)
                if (item.Numer_sali.ToString() == lekarz & item.Data_wizyty == data & item.Godzina_wizyty == godzina & item.ID_wizyty.ToString() != id)
                    return true;
            return false;
        }
    }
}
