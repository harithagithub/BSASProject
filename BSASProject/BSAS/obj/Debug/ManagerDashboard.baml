   M S B A M L   `   `   `  ����B  >WpfApp8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp8WpfApp8  5   	       BSASGUI.ManagerDashboard   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp8     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$ ThreeDBorderWindow=�5	   	   
������� � Title$ Manager Dashboard��5   	   $	��600��6#   $	��800��60   $��15(�6<   .��5      �  � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��50 �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $	��500 �6   .+�5   
   �� $��0��6   $��0��6#    �� Orientation$ 
Horizontal=�63   .+�5      �� -   5         ��Name$ 
txtSearch1��5      $��26��6*   $	��100��66   $
��10,5q�6B   6P   �� 5      -   5         ��Name$ 
btnSearch1��5      $��Search��6)   $��26��6:   $	��100��6G   $
��5,10q�6S   6a   5      �� 5!   
   $��0��6   $��1��6#   $ 
Horizontal=�63   .+�5"      �� -   5        $ btnAdmin��5"      $��Admin��6'   $��26��67   $	��100��6D   $��10,10q�6P   6_   �� 5#      -   5        $ 
btnProduct��5#      $��Products��6)   $��26��6<   $	��100��6I   $��10,10q�6U   6d   �� 5$      -   5        $ btnAppointment��5$      $��Appointments��6-   $��26��6D   $	��100��6Q   $��10,10q�6]   6l   �� 5%      -   5        $ 	btnLogout��5%      $��Logout��6(   $��26��69   $	��100��6F   $��10,22q�6R   6a   5&      ]� 5'   
   $��1��6   $��0��6!   $��2��61   $��
5,5,5,-226q�6E   .+�5(      �� $��3q�6   
���   � �� CornerRadius$ 10��6=   	 �� Padding$	 4q�6O   $��
0,0,0,-200q�6\   
 J� Effect
 5)      3  -System.Windows.Media.Effects.DropShadowEffect  5*         Color$
 Gray��6'      Opacity$ .5Q�5+   '      ShadowDepth$ 4Q�5,   '   ._�5.       � -   5        $��frmMain��5.        � NavigationUIVisibility$ Hidden=�6'   $��
0,3,0,-108q�6G   $	��770��6[   $	��480��6�   $	��Top=�6�   5/      51      58      59      