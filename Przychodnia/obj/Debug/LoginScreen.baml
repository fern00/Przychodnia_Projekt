   M S B A M L   `   `   `  ����F  BPrzychodnia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:PrzychodniaPrzychodnia  5   	       Przychodnia.LoginScreen   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Przychodnia     5   	     � Title$  Przychodnia��5   	   $	��450��6   $	��800��6*    � 
ResizeMode$ NoResize=�66    � WindowStartupLocation$ CenterScreen=�6L    � Icon$ Images/clinic.ico��6q   .��5	      � ��5
   
   �� 5       j� Stretch$
 Fill=�6    �� ImageSource$ /Images/background.jpg��6(    j� 
AlignmentY$	 Top=�6M    j� 
AlignmentX$ Center=�6^   .+�5   
   �� 
����  �$��2q�6(   $��Center=�6<   $��Center=�6Y   ._�5      � $	��300��6   $	��200��6   
������� � RowDefinitions 5      �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $
��1.5* �6$   .+�5      �� $��Login:��6   $��0��6)   $��Bottom=�66   $
��Left=�6Q   $��20(�6m   $��40��6{      Przychodnia.TextBoxLogin  5      -   5        	  Name$	 textBoxLogin��5   %   $��1��6;   $
��10 0q�6H   $��18(�6V   $
��Left=�6d   $��Center=�6   $	��250��5   %   
   Text
 61   ��  �� Path$ Login� �� Mode$ TwoWay=��� 5      $��Hasło:��6   $��2��6)   $��Bottom=�66   $
��Left=�6Q   $��20(�6l   $��40��6z   G� 5       -   5         G�Name$ textBoxPassword��5       $��3��67   $
��10 0q�6D   $��18(�6R   $
��Left=�6`   $	��Top=�6{   $	��250��6�   �� 5"      -   5        $	��100��5"      $��30��6%   $��4��62   $��0 0 10 0q�6?   $��Right=�6Q   $��18(�6m   $��Zaloguj��6{   6�   5#      5$      5%      5&      