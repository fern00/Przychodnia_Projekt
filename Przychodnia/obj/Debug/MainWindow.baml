   M S B A M L   `   `   `  ����  Przychodnia    Przychodnia.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  Przychodnia��5   	   $	��700��6   $
��1200��6*    � 
ResizeMode$ NoResize=�67    � WindowStartupLocation$ CenterScreen=�6M    � Icon$ Images/clinic.ico��6r   .��5	      � -   5         �Name$ Window��5	      ���#99ccff � RowDefinitions 5
   
   �� 5      $��0.12* �6   �� 5      $��0.88* �6   �� 5      $��0.05* �6   .+�5   
   � -   5        $
 Menu��5      $��0��6    � ColumnDefinitions 5      �� 5      $
��0.3* �6#   �� 5      .+�5      �� -   5        $��TabsComboBox��5      $��0��6+   $	��250��6;   $��25��6G    �� SelectedIndex$ 0��6S   
�������6�   �� 5      $��1��6    �� Orientation$ 
Horizontal=�6)   $��Center=�6B   .+�5      �� -   5        	 ��Name$	 
AddContent��5      $��Dodaj��6-   $	��150��6W   $��10q�6c   
�������$��16(�6�   $
��Bold"�6�   �� 5      -   5        $	 EditContent��5      $��Edytuj��6.   $	��150��6W   $��10q�6c   
�������$��16(�6�   $
��Bold"�6�   �� 5      -   5        $	 DeleteContent��5      $��Usuń��60   $	��150��6Y   $��10q�6e   
�������$��16(�6�   $
��Bold"�6�   �� 5      -   5        $	 TodayAppointmentsButton��5      $��Dzisiejsze wizyty��6:   $	��150��6u   $��10q�6�   
�������$��16(�6�   $
��Bold"�6�   �� 5      -   5        $	 PatientAppointmentsButton��5      $��Wizyty Pacjenta��6<   $	��150��6x   $��10q�6�   
�������$��16(�6�   $
��Bold"�6�   5      5      � 5    
   -	   5        $ 
TableSpace��5       $��1��6<   $��10 20 10 10q�6I   � 5"   
   $��2��6   .+�5#      �� -
   5        
 ��Name$
 LoginAs��5#   8   $ ��Jesteś zalogowany/a jako ��6   $��12(�6I   $
��Left=�6W   �� 5$      -   5        $��Wyloguj��5$      $��Right=�66   $��80��6R   $��20��6]   $��5q�6j   
�������6u   5'      5)      5*      