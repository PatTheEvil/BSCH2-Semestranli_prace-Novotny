   M S B A M L   `   `   `  ����H  DBSCH2-Novotny, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:BSCH2_NovotnyBSCH2_Novotny  5   	        BSCH2_Novotny.AddEditVojak   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:BSCH2_Novotny     5   	     � Title$  AddEditVojak��5   	   $	��195��6   $	��260��6+    � 
ResizeMode$ NoResize=�67   .��5	      � .+�5   
   �� $��Jméno:��6   $
��Left=�6!   $��	10,10,0,0q�6<   $	��Top=�6O   $	��100��6g   $��26��6s   �� 5   
   -   5         ��Name$ Tb_jmeno��5      $
��Left=�6J   $��
115,13,0,0q�6e    �� TextWrapping$
 Wrap=�6y   $	��Top=�6�   $	��120��6�   $��20��6�   ��6$   �� *Jmeno+ �� Mode$ TwoWay=�6�   �� 5   
   $��Příjmění:��6   $
��Left=�6$   $��	10,41,0,0q�6?   $	��Top=�6R   $	��100��6j   $��26��6v   �� 5   
   -   5        $ Tb_prijmeni��5      $
��Left=�6P   $��
115,44,0,0q�6k   $
 Wrap=�6   $	��Top=�6�   $	��120��6�   $��20��6�   ��6'   �� *
Prijmeni+$ TwoWay=�6�   �� 5   
   $��Datum narození:��6   $
��Left=�6*   $��	10,72,0,0q�6E   $	��Top=�6X   $	��100��6p   $��26��6|   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ Dp_narozeni��5      $
��Left=�6*   $��
115,72,0,0q�6E   $	��Top=�6Y      FirstDayOfWeek$ Monday=�6q      SelectedDateFormat$ Short=�6�   $��26��6�   $	��120��6�      SelectedDate 6�   �� *
Narozeni+$ TwoWay=�6�   �� 5   
   -   5        	 ��Name$	 
Btn_storno��5      $��Storno��6%   $
��Left=�66   $��
10,128,0,0q�6Q   $	��Top=�6e   $��20��6}   $��50��6�   ��6�   �� *CloseCommand+�� 5   
   -   5        $	 Btn_OK��5      $��OK��6!   $
��Left=�6.   $��185,128,0,0q�6I   $	��Top=�6^   $��20��6v   $��50��6�   ��6�   �� *AddVojakCommand+5      5      