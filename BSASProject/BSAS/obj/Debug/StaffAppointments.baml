   M S B A M L   `   `   `  ����B  >WpfApp8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp8WpfApp8  5          BSASGUI.StaffAppointments   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp8     5        N� 
Background
  ����� N� Title$ StaffAppointments��5
      .��5      �� $��10,10q�6   .@�5      �� $��ViewAppointments��6   $	��130��6)   $
��Left=�67   $��31��6R   .��5   
   �  � ColumnDefinitions 5      �� 5      $	��300 �6#   �� 5      $	��350 �6#    � RowDefinitions 5      �� 5      $	��150 �6    �� 5      $	��170 �6    �� 5      $
��auto �6    .+�5      �� -   5         ��Name$ lstAppointmetsList��5      $��0��64   $��2��6A   $��10,0,0,0q�6U    �� View 5      �� 5      .P�5       �� $��UserName��6)    �� Width$	 150��6;    �� CellTemplate 5!      �� 5"   "   .R�5#   &   �� $��Stretch=�60   $
��Wrap=�6N   5$   #   5&      �� 5'      $��AppointmentType��6)   $	 190��6B    5(      �� 5)   "   .R�5*   &   �� $��Stretch=�60   $
��Wrap=�6N   5+   #   5-      �� 5.      $
��Time��6)   $	 150��67    5/      �� 50   "   .R�51   &   �� $��Stretch=�60   $
��Wrap=�6N   52   #   54      �� 55      $��Price��6)   $	 150��68    56      �� 57   "   .R�58   &   �� $��Stretch=�60   $
��Wrap=�6N   59   #   5;      5>      5A      5B      5C      5D      5F      