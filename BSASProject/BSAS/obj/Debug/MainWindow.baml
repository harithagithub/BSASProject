   M S B A M L   `   `   `  ����B  >WpfApp8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp8WpfApp8  5   	       BSASGUI.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp8     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$ ThreeDBorderWindow=�5	   	   
������� � Title$ 
MainWindow��5   	   $	��500��6   $	��800��6)   $��15(�66   .��5      � $��0,-2,0,2q�6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $	��20. �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $	��100 �6   �� 5      $
��auto �6   .+�5   
   �� -   5        $��	loginPage��5      $��0��5      $��1��5      $��Center=�5      $��
11,20,6,20q�5      $��20(�5       $,��&Please Login to access the Application��5!      $	��346��6A   $��2��6M   �� 5"   
   $��1��6   $��1��6"   $��2��62   .+�5#      �� $��Username��6   $��15(�6(   $
��Left=�66   �� 5$      $��Password��6   $��15(�6(   $
��Left=�66   5%      �� 5&   
   $��1��6   $��2��6"   .+�5'      �� -   5         ��Name$ txtUserName��5'      $��20��6-   $
��10,5q�69   $	��150��6G   6S   G� 5(      -   5         G�Name$ txtPasswordbox��5(      $	��5,5q�63   $��20��6@   $	��150��6L   5)      �� 5*   
   $��2��6   $��1��6"    �� Orientation$ 
Horizontal=�62   $��Right=�6K   $	��195��6g   $��Bottom=�6t   $��	0,0,10,12q�6�   $	��330��6�   $��2��6�   .+�5+      �� -   5        $��btnLogin��5+      $��Login��6%   $��4��65   $��1��6B   $��26��6R   $��90��6^   $��5,44,10,125q�6i   6~   �� 5,      -   5        $��	btnCancel��5,      $��Cancel��6&   $��4��67   $��1��6D   $��26��6T   $��90��6`   $��5,44,10,125q�6k   6�   �� 5-      -   5        $��btnClear��5-      $��Clear��6%   $��4��65   $��1��6B   $��26��6R   $��90��6^   $��5,44,10,125q�6i   6~   5/      �� 50   
   $��2��6   $��0��6"   $	��150��62   .+�51      �� -   5        $��lblErrormessage��51       � DataContext$' !Username or Password is incorrect��6,   $y�Visible=�6_   53      55      56      