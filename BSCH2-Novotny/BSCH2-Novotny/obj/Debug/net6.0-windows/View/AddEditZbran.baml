   M S B A M L   `   `   `  ����H  DBSCH2-Novotny, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:BSCH2_NovotnyBSCH2_Novotny  5   	        BSCH2_Novotny.AddEditZbran   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:BSCH2_Novotny     5   	     � Title$  AddEditZbran��5   	   $	��226��6   $	��300��6+    � 
ResizeMode$ NoResize=�67   .��5	      � .+�5   
   �� $��Název:��6   $
��Left=�6!   $��	10,10,0,0q�6<   $	��Top=�6O   $��70��6g   $��26��6r   �� 5   
   -   5         ��Name$ Tb_nazev��5      $
��Left=�6J   $��	85,13,0,0q�6e    �� TextWrapping$
 Wrap=�6x   $	��Top=�6�   $	��190��6�   $��20��6�   ��6$   �� *Nazev+ �� Mode$ TwoWay=�6�   �� 5   
   $��Voják:��6   $
��Left=�6!   $��	10,41,0,0q�6<   $	��Top=�6O   $��70��6g   $��26��6r   �� 5   
   -   5         ��Name$ Cb_vojak��5      $
��Left=�6%   $��	85,41,0,0q�6@   $	��Top=�6S   $	��190��6k   $��26��6w    �� SelectedValuePath$ Id��6�    �� SelectedIndex$ 0��6�   ��6�   �� *Vojaci+��5      �� 5      .R�5      �� �� 5      �6   �� *Jmeno+ �� 5      $� ��6    �� 5      �6   �� *
Prijmeni+5      5      5      �� 5   
   $��Typ Zbraně:��6   $
��Left=�6&   $��	10,72,0,0q�6A   $	��Top=�6T   $��70��6l   $��26��6w   �� 5   
   -   5        $ Cb_typ��5      $
��Left=�6#   $��	85,72,0,0q�6>   $	��Top=�6Q   $	��190��6i   $��26��6u    �� DisplayMemberPath$	 Typ��6�   $ Id��6�   $ 0��6�   ��6�   �� *Typy+6�   �� 5   
   $��Munice:��6   $
��Left=�6"   $��
10,103,0,0q�6=   $	��Top=�6Q   $��70��6i   $��26��6t   �� 5   
   -   5        $ 	Cb_munice��5      $
��Left=�6&   $��
85,103,0,0q�6A   $	��Top=�6U   $	��190��6m   $��26��6y   $
 Raze��6�   $ Id��6�   $ 0��6�   ��6�   �� *Munice+6�   �� 5   
   -   5        	 ��Name$	 
Btn_storno��5      $��Storno��6%   $
��Left=�66   $��
10,159,0,0q�6Q   $	��Top=�6e   $��20��6}   $��50��6�   ��6�   �� *CloseCommand+�� 5   
   -   5        $	 Btn_OK��5      $��OK��6!   $
��Left=�6.   $��225,159,0,0q�6I   $	��Top=�6^   $��20��6v   $��50��6�   ��6�   �� *AddVojakCommand+5       5!      