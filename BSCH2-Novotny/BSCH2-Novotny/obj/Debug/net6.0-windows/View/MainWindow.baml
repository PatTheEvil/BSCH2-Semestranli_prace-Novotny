   M S B A M L   `   `   `  ����H  DBSCH2-Novotny, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:BSCH2_NovotnyBSCH2_Novotny  5   	       BSCH2_Novotny.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:BSCH2_Novotny     5   	   -   5          � Title$  
MainWindow��5   	   $	��742��6   $
��1000��6)    � SizeToContent$ WidthAndHeight=�66   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��176* �6   �� 5      $
��432* �6   �� 5      $
��490* �6   �� 5      $
��200* �6   .+�5   
   �� -   5         ��Name$ Lv��5      $��10,10,155,10q�6d   $��4��6z    �� SelectionMode$ Single=�6�   $
��Left=�6�   ��6   �� *Vojaci+ �� SelectedItem 6>   �� *SelectedItem+ �� View 5      �� 5      -   5        Gv��5      5      �� 5   
   $��Přidávání:��6   $��Right=�6%   $��	0,10,10,0q�6A   $	��Top=�6T   $	��140��6l   $��25��6x   $��3��6�   �� 5   
   -   5         ��Name$ Btn_prid_vojaka��5      $��Přidat Vojáka��6*   $��Right=�6B   $��	0,40,10,0q�6^   $	��Top=�6q   $	��140��6�   $��20��6�   $��3��6�   {�6�   �� *IsVojakInLv+��6�   �� *AddVojakCommand+�� 5   
   -   5        $ Btn_prid_zbran��5      $��Přidat Zbraň��6)   $��Right=�6@   $��	0,65,10,0q�6\   $	��Top=�6o   $	��140��6�   $��20��6�   $��3��6�   {�6�   �� *IsZbranInLv+��6�   �� *AddZbranCommand+�� 5   
   -   5        $ Btn_prid_typ��5      $��Přidat Typ Zbraně��6'   $��Right=�6C   $��	0,90,10,0q�6_   $	��Top=�6r   $	��140��6�   $��20��6�   $��3��6�   {�6�   �� *	IsTypInLv+��6�   �� *AddTypCommand+�� 5   
   -   5        $ Btn_prid_munici��5      $��Přidat Munici��6*   $��Right=�6B   $��
0,115,10,0q�6^   $	��Top=�6r   $	��140��6�   $��20��6�   $��3��6�   {�6�   �� *IsMuniceInLv+��6�   �� *AddMuniceCommand+�� 5   
   $��Zobrazenní:��6   $��Right=�6&   $��
0,150,10,0q�6B   $	��Top=�6V   $��25��6n   $	��140��6z   $��3��6�   �� 5   
   -   5        $ Btn_zobr_typy��5      $��Zobrazit Typy Zbraní��6(   $��Right=�6G   $��
0,230,10,0q�6c   $	��Top=�6w   $	��140��6�   $��20��6�   $��3��6�   ��6�   �� *ShowTypCommand+�� 5   
   -	   5        $ Btn_zobr_vojaky��5      $��Zobrazit Vojáky��6*   $��Right=�6D   $��
0,180,10,0q�6`   $	��Top=�6t   $	��140��6�   $��20��6�   $��3��6�   ��6�   �� *ShowVojakCommand+�� 5   
   -
   5        $ Btn_zobr_zbrane��5      $��Zobrazit Zbraně��6*   $��Right=�6D   $��
0,205,10,0q�6`   $	��Top=�6t   $	��140��6�   $��20��6�   $��3��6�   ��6�   �� *ShowZbranCommand+�� 5   
   -   5        $ Btn_zobr_munici��5      $��Zobrazit Munici��6*   $��Right=�6D   $��
0,255,10,0q�6`   $	��Top=�6t   $	��140��6�   $��20��6�   $��3��6�   ��6�   �� *ShowMuniceCommand+�� 5    
   $��Úprava:��6   $��Right=�6"   $��
0,290,10,0q�6>   $	��Top=�6R   $��25��6j   $	��140��6v   $��3��6�   �� 5!   
   -   5        $ Btn_uprav_vojaka��5!      $��Upravit vojáka��6+   $��Right=�6D   $��
0,320,10,0q�6`   $	��Top=�6t   $	��140��6�   $��20��6�   $��3��6�   {�6�   �� *IsVojakSelected+��6�   �� *EditVojakCommand+�� 5"   
   -   5        $ Btn_uprav_zbran��5"      $��Upravit Zbraň��6*   $��Right=�6B   $��
0,345,10,0q�6^   $	��Top=�6r   $	��140��6�   $��20��6�   $��3��6�   {�6�   �� *IsZbranSelected+��6�   �� *EditZbranCommand+�� 5#   
   -   5        $ Btn_uprav_typ��5#      $��Upravit Typ Zbraně��6(   $��Right=�6E   $��
0,370,10,0q�6a   $	��Top=�6u   $	��140��6�   $��20��6�   $��3��6�   {�6�   �� *IsTypSelected+��6�   �� *EditTypCommand+�� 5$   
   -   5        $ Btn_uprav_munici��5$      $��Upravit Munici��6+   $��Right=�6D   $��
0,395,10,0q�6`   $	��Top=�6t   $	��140��6�   $��20��6�   $��3��6�   {�6�   �� *IsMuniceSelected+��6�   �� *EditMuniceCommand+�� 5%   
   $��	Mazání:��6   $��Right=�6"   $��
0,430,10,0q�6>   $	��Top=�6R   $	��140��6j   $��25��6v   $��3��6�   �� 5&   
   -   5        $ Btn_smaz_vojaka��5&      $��Smazat Vojáka��6*   $��Right=�6B   $��
0,460,10,0q�6^   $	��Top=�6r   $	��140��6�   $��20��6�   $��3��6�   {�6�   �� *IsVojakSelected+��6�   �� *DeleteVojakCommand+�� 5'   
   -   5        $ Btn_smaz_zbran��5'      $��Smazat Zbraň��6)   $��Right=�6@   $��
0,485,10,0q�6\   $	��Top=�6p   $	��140��6�   $��20��6�   $��3��6�   {�6�   �� *IsZbranSelected+��6�   �� *DeleteZbranCommand+�� 5(   
   -   5        $ Btn_smaz_typ��5(      $��Smazat Typ Zbraně��6'   $��Right=�6C   $��
0,510,10,0q�6_   $	��Top=�6s   $	��140��6�   $��20��6�   $��3��6�   {�6�   �� *IsTypSelected+��6�   �� *DeleteTypCommand+�� 5)   
   -   5        $ Btn_smaz_munici��5)      $��Smazat Munici��6*   $��Right=�6B   $��
0,535,10,0q�6^   $	��Top=�6r   $	��140��6�   $��20��6�   $��3��6�   {�6�   �� *IsMuniceSelected+��6�   �� *DeleteMuniceCommand+�� 5*   
   -   5        $ Btn_smaz_vse��5*      $��Smazat Vše��6'   $��Right=�6<   $��
0,570,10,0q�6X   $	��Top=�6l   $	��140��6�   $��20��6�   $��3��6�   ��6�   �� *DeleteAllCommand+�� 5+   
   $��Filtry Zbraní:��6   $��Right=�6)   $��
0,605,10,0q�6E   $	��Top=�6Y   $	��140��6q   $��25��6}   $��3��6�   �� 5,   
   -   5         ��Name$ Cb_typ��5,      $��Right=�6#   $��
0,635,10,0q�6?   $	��Top=�6S   $	��140��6k   $��25��6w   	 �� 
IsReadOnly$
	 True��6�   $��3��6�   
 �� DisplayMemberPath$	
 Typ��6�    �� SelectedValuePath$ Id��6�   {�6�   �� *IsZbranInLv+��6�   �� *TypyCb+ 6  �� *SelectedTyp+ �� Mode$ TwoWay=��� 5-   
   -   5        $ 	Cb_munice��5-      $��Right=�6&   $��
0,665,10,0q�6B   $	��Top=�6V   $	��140��6n   $��25��6z   $
	 True��6�   $��3��6�   $

 Raze��6�   $ Id��6  {�6�   �� *IsZbranInLv+��6�   �� *
MuniceCb+ 6  �� *SelectedMunice+$ TwoWay=�5/      50      