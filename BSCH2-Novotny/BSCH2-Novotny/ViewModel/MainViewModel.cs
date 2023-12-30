using BSCH2_Novotny.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace BSCH2_Novotny.ViewModel
{
	public class MainViewModel : INotifyPropertyChanged
	{
		ListView Lv { get; set; }
		GridView Gv { get; set; }
		public ObservableCollection<Vojak> Vojaci { get; set; }
		public ObservableCollection<Typ_zbrane> Typy { get; set; }
		public ObservableCollection<Munice> Munice { get; set; }
		public ObservableCollection<Zbran> Zbrane { get; set; }
		public ObservableCollection<Zbran> ZbraneFiltered { get; set; }
		public ObservableCollection<Typ_zbrane> TypyCb { get; set; }
		public ObservableCollection<Munice> MuniceCb { get; set; }
		public ComboBox Cb_Typy { get; set; }
		public ComboBox Cb_Munice { get; set; }

		public MainViewModel(ListView listView, GridView gridView, ComboBox Cb_typ, ComboBox Cb_munice)
		{
			Lv = listView;
			Gv = gridView;

			HandleListViewSelectionChanged();

			ShowVojak();

			TypyCb = new ObservableCollection<Typ_zbrane>();
			MuniceCb = new ObservableCollection<Munice>();

			LoadData();

			Cb_Typy = Cb_typ;
			Cb_Munice = Cb_munice;
		}

		private void LoadData()
		{
			TypyCb.Add(new Typ_zbrane() { Id = null, Typ = "Bez Filtru" });
			foreach (Typ_zbrane typ in TypManager.GetTypy())
			{
				TypyCb.Add(typ);
			}

			MuniceCb.Add(new Munice() { Id = null, Raze = "Bez Filtru" });
			foreach (Munice munice in MuniceManager.GetMunice())
			{
				MuniceCb.Add(munice);
			}

			OnPropertyChanged(nameof(TypyCb));
			OnPropertyChanged(nameof(MuniceCb));

			SelectedTyp = TypyCb.First();
			SelectedMunice = MuniceCb.First();
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}


		private bool _isVojakSelected;
		public bool IsVojakSelected
		{
			get { return _isVojakSelected; }
			set
			{
				if (_isVojakSelected != value)
				{
					_isVojakSelected = value;
					OnPropertyChanged(nameof(IsVojakSelected));
				}
			}
		}

		private bool _isTypSelected;
		public bool IsTypSelected
		{
			get { return _isTypSelected; }
			set
			{
				_isTypSelected = value;
				OnPropertyChanged(nameof(IsTypSelected));
			}
		}

		private bool _isMuniceSelected;
		public bool IsMuniceSelected
		{
			get { return _isMuniceSelected; }
			set
			{
				_isMuniceSelected = value;
				OnPropertyChanged(nameof(IsMuniceSelected));
			}
		}

		private bool _isZbranSelected;
		public bool IsZbranSelected
		{
			get { return _isZbranSelected; }
			set
			{
				_isZbranSelected = value;
				OnPropertyChanged(nameof(IsZbranSelected));
			}
		}

		private bool _isVojakInLv;
		public bool IsVojakInLv
		{
			get { return _isVojakInLv; }
			set
			{
				_isVojakInLv = value;
				OnPropertyChanged(nameof(IsVojakInLv));
			}
		}

		private bool _isMuniceInLv;
		public bool IsMuniceInLv
		{
			get { return _isMuniceInLv; }
			set
			{
				_isMuniceInLv = value;
				OnPropertyChanged(nameof(IsMuniceInLv));
			}
		}

		private bool _isTypInLv;
		public bool IsTypInLv
		{
			get { return _isTypInLv; }
			set
			{
				_isTypInLv = value;
				OnPropertyChanged(nameof(IsTypInLv));
			}
		}

		private bool _isZbranInLv;
		public bool IsZbranInLv
		{
			get { return _isZbranInLv; }
			set
			{
				_isZbranInLv = value;
				OnPropertyChanged(nameof(IsZbranInLv));
			}
		}




		private void UpdateButtonStates()
		{
			try
			{
				IsVojakSelected = Lv.SelectedItem is Vojak;
				OnPropertyChanged(nameof(EditVojakCommand)); // Aktualizuje stav tlačítka

				IsTypSelected = Lv.SelectedItem is Typ_zbrane;
				OnPropertyChanged(nameof(EditTypCommand));

				IsMuniceSelected = Lv.SelectedItem is Munice;
				OnPropertyChanged(nameof(EditMuniceCommand));

				IsZbranSelected = Lv.SelectedItem is Zbran;
				OnPropertyChanged(nameof(EditZbranCommand));

				OnPropertyChanged(nameof(AddVojakCommand));

				OnPropertyChanged(nameof(AddMuniceCommand));

				OnPropertyChanged(nameof(AddTypCommand));

				OnPropertyChanged(nameof(AddZbranCommand));
			}
			catch (Exception ex)
			{

			}
		}

		private void HandleListViewSelectionChanged()
		{
			Lv.SelectionChanged += (sender, e) => { UpdateButtonStates(); };
		}

		private ICommand _editVojakCommand;
		public ICommand EditVojakCommand
		{
			get
			{
				if (_editVojakCommand == null)
				{
					_editVojakCommand = new RelayCommand(param => EditVojak(), CanEditVojak);
				}
				return _editVojakCommand;
			}
		}

		private bool CanEditVojak(object obj)
		{
			return IsVojakSelected; // Vrátí true/false podle stavu výběru v ListView
		}

		private void EditVojak()
		{

			AddEditVojak addEditVojak = new AddEditVojak((Vojak)Lv.SelectedItem);
			addEditVojak.Closed += (sender, e) => ShowVojak();
			addEditVojak.Show();
		}




		private ICommand _editMuniceCommand;
		public ICommand EditMuniceCommand
		{
			get
			{
				if (_editMuniceCommand == null)
				{
					_editMuniceCommand = new RelayCommand(param => EditMunice(), CanEditMunice);
				}
				return _editMuniceCommand;
			}
		}

		private bool CanEditMunice(object obj)
		{
			return IsMuniceSelected; // Vrátí true/false podle stavu výběru v ListView
		}

		private void EditMunice()
		{
			AddEditMunice addEditMunice = new AddEditMunice((Munice)Lv.SelectedItem);
			addEditMunice.Closed += (sender, e) => ShowMunice();
			addEditMunice.Show();
		}




		private ICommand _editTypCommand;
		public ICommand EditTypCommand
		{
			get
			{
				if (_editTypCommand == null)
				{
					_editTypCommand = new RelayCommand(param => EditTyp(), CanEditTyp);
				}
				return _editTypCommand;
			}
		}

		private bool CanEditTyp(object obj)
		{
			return IsTypSelected; // Vrátí true/false podle stavu výběru v ListView
		}

		private void EditTyp()
		{
			AddEditTyp addEditTyp = new AddEditTyp((Typ_zbrane)Lv.SelectedItem);
			addEditTyp.Closed += (sender, e) => ShowTyp();
			addEditTyp.Show();
		}




		private ICommand _editZbranCommand;
		public ICommand EditZbranCommand
		{
			get
			{
				if (_editZbranCommand == null)
				{
					_editZbranCommand = new RelayCommand(param => EditZbran(), CanEditZbran);
				}
				return _editZbranCommand;
			}
		}

		private bool CanEditZbran(object obj)
		{
			return IsZbranSelected; // Vrátí true/false podle stavu výběru v ListView
		}

		private void EditZbran()
		{
			AddEditZbran addEditZbran = new AddEditZbran((Zbran)Lv.SelectedItem);
			addEditZbran.Closed += (sender, e) => ShowZbran();
			addEditZbran.Show();
		}




		private ICommand _deleteVojakCommand;
		public ICommand DeleteVojakCommand
		{
			get
			{
				if (_deleteVojakCommand == null)
				{
					_deleteVojakCommand = new RelayCommand(param => DeleteVojak(), CanDeleteVojak);
				}
				return _deleteVojakCommand;
			}
		}

		private bool CanDeleteVojak(object obj)
		{
			return IsVojakSelected; // Vrátí true/false podle stavu výběru v ListView
		}

		private void DeleteVojak()
		{
			VojakManager.DeleteById(((Vojak)Lv.SelectedItem).Id);
			ShowVojak();
		}




		private ICommand _deleteMuniceCommand;
		public ICommand DeleteMuniceCommand
		{
			get
			{
				if (_deleteMuniceCommand == null)
				{
					_deleteMuniceCommand = new RelayCommand(param => DeleteMunice(), CanDeleteMunice);
				}
				return _deleteMuniceCommand;
			}
		}

		private bool CanDeleteMunice(object obj)
		{
			return IsMuniceSelected; // Vrátí true/false podle stavu výběru v ListView
		}

		private void DeleteMunice()
		{
			MuniceManager.DeleteById(((Munice)Lv.SelectedItem).Id);
			ShowMunice();
		}




		private ICommand _deleteTypCommand;
		public ICommand DeleteTypCommand
		{
			get
			{
				if (_deleteTypCommand == null)
				{
					_deleteTypCommand = new RelayCommand(param => DeleteTyp(), CanDeleteTyp);
				}
				return _deleteTypCommand;
			}
		}

		private bool CanDeleteTyp(object obj)
		{
			return IsTypSelected; // Vrátí true/false podle stavu výběru v ListView
		}

		private void DeleteTyp()
		{
			TypManager.DeleteById(((Typ_zbrane)Lv.SelectedItem).Id);
			ShowTyp();
		}




		private ICommand _deleteZbranCommand;
		public ICommand DeleteZbranCommand
		{
			get
			{
				if (_deleteZbranCommand == null)
				{
					_deleteZbranCommand = new RelayCommand(param => DeleteZbran(), CanDeleteZbran);
				}
				return _deleteZbranCommand;
			}
		}

		private bool CanDeleteZbran(object obj)
		{
			return IsZbranSelected; // Vrátí true/false podle stavu výběru v ListView
		}

		private void DeleteZbran()
		{
			ZbranManager.DeleteById(((Zbran)Lv.SelectedItem).Id);
			ShowZbran();
		}




		private ICommand _addVojakCommand;
		public ICommand AddVojakCommand
		{
			get
			{
				if (_addVojakCommand == null)
				{
					_addVojakCommand = new RelayCommand(param => AddVojak(), CanAddVojak);
				}
				return _addVojakCommand;
			}
		}

		private bool CanAddVojak(object obj)
		{
			return IsVojakInLv;
		}

		private void AddVojak()
		{
			AddEditVojak addEditVojak = new AddEditVojak();
			addEditVojak.Closed += (sender, e) => ShowVojak();
			addEditVojak.Show();
		}




		private ICommand _addMuniceCommand;
		public ICommand AddMuniceCommand
		{
			get
			{
				if (_addMuniceCommand == null)
				{
					_addMuniceCommand = new RelayCommand(param => AddMunice(), CanAddMunice);
				}
				return _addMuniceCommand;
			}
		}

		private bool CanAddMunice(object obj)
		{
			return IsMuniceInLv;
		}

		private void AddMunice()
		{
			AddEditMunice addEditMunice = new AddEditMunice();
			addEditMunice.Closed += (sender, e) => ShowMunice();
			addEditMunice.Show();
		}




		private ICommand _addTypCommand;
		public ICommand AddTypCommand
		{
			get
			{
				if (_addTypCommand == null)
				{
					_addTypCommand = new RelayCommand(param => AddTyp(), CanAddTyp);
				}
				return _addTypCommand;
			}
		}

		private bool CanAddTyp(object obj)
		{
			return IsTypInLv;
		}

		private void AddTyp()
		{
			AddEditTyp addEditTyp = new AddEditTyp();
			addEditTyp.Closed += (sender, e) => ShowTyp();
			addEditTyp.Show();
		}




		private ICommand _addZbranCommand;
		public ICommand AddZbranCommand
		{
			get
			{
				if (_addZbranCommand == null)
				{
					_addZbranCommand = new RelayCommand(param => AddZbran(), CanAddZbran);
				}
				return _addZbranCommand;
			}
		}

		private bool CanAddZbran(object obj)
		{
			return IsZbranInLv;
		}

		private void AddZbran()
		{
			AddEditZbran addEditZbran = new AddEditZbran();
			addEditZbran.Closed += (sender, e) => ShowZbran();
			addEditZbran.Show();

		}




		private ICommand _showVojakCommand;
		public ICommand ShowVojakCommand
		{
			get
			{
				if (_showVojakCommand == null)
				{
					_showVojakCommand = new RelayCommand(param => ShowVojak(), CanShowVojak);
				}
				return _showVojakCommand;
			}
		}

		private bool CanShowVojak(object obj)
		{
			return true;
		}

		private void ShowVojak()
		{
			Vojaci = VojakManager.GetVojaci();
			Lv.ItemsSource = Vojaci;

			Gv.Columns.Clear();

			Gv.Columns.Add(new GridViewColumn() { Header = "Id", DisplayMemberBinding = new Binding("Id") });
			Gv.Columns.Add(new GridViewColumn() { Header = "Jméno", DisplayMemberBinding = new Binding("Jmeno") });
			Gv.Columns.Add(new GridViewColumn() { Header = "Příjmení", DisplayMemberBinding = new Binding("Prijmeni") });
			Gv.Columns.Add(new GridViewColumn() { Header = "Narození", DisplayMemberBinding = new Binding("Narozeni") });

			IsVojakInLv = true;
			IsTypInLv = false;
			IsMuniceInLv = false;
			IsZbranInLv = false;

		}




		private ICommand _showTypCommand;
		public ICommand ShowTypCommand
		{
			get
			{
				if (_showTypCommand == null)
				{
					_showTypCommand = new RelayCommand(param => ShowTyp(), CanShowTyp);
				}
				return _showTypCommand;
			}
		}

		private bool CanShowTyp(object obj)
		{
			return true;
		}

		private void ShowTyp()
		{
			Typy = TypManager.GetTypy();
			Lv.ItemsSource = Typy;

			Gv.Columns.Clear();

			Gv.Columns.Add(new GridViewColumn() { Header = "Id", DisplayMemberBinding = new Binding("Id") });
			Gv.Columns.Add(new GridViewColumn() { Header = "Typ", DisplayMemberBinding = new Binding("Typ") });

			IsVojakInLv = false;
			IsTypInLv = true;
			IsMuniceInLv = false;
			IsZbranInLv = false;

		}




		private ICommand _showMuniceCommand;
		public ICommand ShowMuniceCommand
		{
			get
			{
				if (_showMuniceCommand == null)
				{
					_showMuniceCommand = new RelayCommand(param => ShowMunice(), CanShowMunice);
				}
				return _showMuniceCommand;
			}
		}

		private bool CanShowMunice(object obj)
		{
			return true;
		}

		private void ShowMunice()
		{
			Munice = MuniceManager.GetMunice();
			Lv.ItemsSource = Munice;

			Gv.Columns.Clear();

			Gv.Columns.Add(new GridViewColumn() { Header = "Id", DisplayMemberBinding = new Binding("Id") });
			Gv.Columns.Add(new GridViewColumn() { Header = "Ráže", DisplayMemberBinding = new Binding("Raze") });

			IsVojakInLv = false;
			IsTypInLv = false;
			IsMuniceInLv = true;
			IsZbranInLv = false;

		}




		private ICommand _showZbranCommand;
		public ICommand ShowZbranCommand
		{
			get
			{
				if (_showZbranCommand == null)
				{
					_showZbranCommand = new RelayCommand(param => ShowZbran(), CanShowZbran);
				}
				return _showZbranCommand;
			}
		}

		private bool CanShowZbran(object obj)
		{
			return true;
		}

		private void ShowZbran()
		{

			Zbrane = ZbranManager.GetZbrane();
			Lv.ItemsSource = Zbrane;

			Gv.Columns.Clear();

			Gv.Columns.Add(new GridViewColumn() { Header = "Id", DisplayMemberBinding = new Binding("Id") });
			Gv.Columns.Add(new GridViewColumn() { Header = "Název", DisplayMemberBinding = new Binding("Nazev") });
			Gv.Columns.Add(new GridViewColumn() { Header = "Jméno vojáka", DisplayMemberBinding = new Binding("Vojak.Jmeno") });
			Gv.Columns.Add(new GridViewColumn() { Header = "Příjmení vojáka", DisplayMemberBinding = new Binding("Vojak.Prijmeni") });
			Gv.Columns.Add(new GridViewColumn() { Header = "Typ zbraně", DisplayMemberBinding = new Binding("Typ.Typ") });
			Gv.Columns.Add(new GridViewColumn() { Header = "Ráže", DisplayMemberBinding = new Binding("Munice.Raze") });

			IsVojakInLv = false;
			IsTypInLv = false;
			IsMuniceInLv = false;
			IsZbranInLv = true;


		}


		private ICommand _deleteAllCommand;
		public ICommand DeleteAllCommand
		{
			get
			{
				if (_deleteAllCommand == null)
				{
					_deleteAllCommand = new RelayCommand(param => DeleteAll(), CanDeleteAll);
				}
				return _deleteAllCommand;
			}
		}

		private bool CanDeleteAll(object obj)
		{
			return true;
		}

		private void DeleteAll()
		{
			ZbranManager.DeleteAll();
			VojakManager.DeleteAll();
			TypManager.DeleteAll();
			MuniceManager.DeleteAll();

			ShowVojak();
		}

		private Typ_zbrane _selectedTyp;
		public Typ_zbrane SelectedTyp
		{
			get { return _selectedTyp; }
			set
			{
				_selectedTyp = value;
				OnPropertyChanged(nameof(SelectedTyp));
				ShowFilteredZbran(); // Aplikuje filtr na základě vybraného Typ_zbrane
			}
		}

		private Munice _selectedMunice;
		public Munice SelectedMunice
		{
			get { return _selectedMunice; }
			set
			{
				_selectedMunice = value;
				OnPropertyChanged(nameof(SelectedMunice));
				ShowFilteredZbran(); // Aplikuje filtr na základě vybrané Munice
			}
		}


		private void ShowFilteredZbran()
		{
			ZbraneFiltered = new ObservableCollection<Zbran>();
			ZbraneFiltered.Clear();
			if (SelectedTyp != null && SelectedMunice != null)
			{
				if (SelectedTyp.Id != null && SelectedMunice.Id != null)
				{
					foreach (Zbran zbran in ZbranManager.GetZbrane())
					{
						if (zbran.Typ.Id == SelectedTyp.Id && zbran.Munice.Id == SelectedMunice.Id)
						{
							ZbraneFiltered.Add(zbran);
							Lv.ItemsSource = ZbraneFiltered;
						}
					}
				}
				else if (SelectedTyp.Id != null)
				{
					foreach (Zbran zbran in ZbranManager.GetZbrane())
					{
						if (zbran.Typ.Id == SelectedTyp.Id)
						{
							ZbraneFiltered.Add(zbran);
							Lv.ItemsSource = ZbraneFiltered;
						}
					}
				}
				else if (SelectedMunice.Id != null)
				{
					foreach (Zbran zbran in ZbranManager.GetZbrane())
					{
						if (zbran.Munice.Id == SelectedMunice.Id)
						{
							ZbraneFiltered.Add(zbran);
							Lv.ItemsSource = ZbraneFiltered;
						}
					}
				}
				else
				{
					ShowZbran();
				}
			}
		}
	}
}
