   M S B A M L   `   `   `  ����N  JEX29WPFMusicLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:EX29WPFMusicLibraryEX29WPFMusicLibrary  5   	   $    EX29WPFMusicLibrary.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:EX29WPFMusicLibrary     5   	     � Title$  	Playliste��5   	   $	��600��6   $	��800��6(   .��5	      � .+�5
   
   �� $��Artist:��6   $
��Left=�6"   $��
145,74,0,0q�6=   $	��Top=�6Q   �� 5   
   $��Titel:��6   $
��Left=�6!   $��149,177,0,0q�6<   $	��Top=�6Q   �� 5   
   $��Længde:��6   $
��Left=�6"   $��
79,257,0,0q�6=   $	��Top=�6Q   �� 5   
   -   5         ��Name$ 	lbxTracks��5      $��400,37,16,236q�6%   �� 5   
   -   5         ��Name$ 	tbxArtist��5      $
��Left=�6%   $��
242,78,0,0q�6@   $��Jack Harlow��6T    �� TextWrapping$
 Wrap=�6g   $	��Top=�6{   $	��120��6�   �� 5   
   -   5        $ tbxTitle��5      $
��Left=�6$   $��242,181,0,0q�6?   $��What's Popping��6T   $
 Wrap=�6j   $	��Top=�6~   $	��120��6�   �� 5   
   -   5        $ tbxMin��5      $
��Left=�6"   $��195,261,0,0q�6=   $��3��6R   $
 Wrap=�6[   $	��Top=�6o   $��54��6�   �� 5   
   -   5        $ tbxSec��5      $
��Left=�6"   $��283,261,0,0q�6=   $��13��6R   $
 Wrap=�6\   $	��Top=�6p   $��60��6�   �� 5   
   $
��Min:��6   $
��Left=�6   $��203,235,0,0q�6:   $	��Top=�6O   �� 5   
   $
��Sek:��6   $
��Left=�6   $��294,235,0,0q�6:   $	��Top=�6O   �� 5   
   $��Korteste sang:��6   $
��Left=�6)   $��442,517,0,0q�6D   $	��Top=�6Y   �� 5   
   -   5         ��Name$ lblShortTrack��5      $��Ingen sange tilføjet��6'   $
��Left=�6F   $��536,517,0,0q�6a   $	��Top=�6v   �� 5   
   -   5         ��Name$ 
btnAddSong��5      $��Tilføj til Playlist��6%   $
��Left=�6C   $��242,304,0,0q�6^   $	��Top=�6s   6�   �� 5   
   -   5        $ btnRemoveSong��5      $��	Slet sang��6(   $
��Left=�6<   $��416,360,0,0q�6W   $	��Top=�6l   6�   �� 5   
   -	   5        $ lblfejl��5      $�� ��6!   $
��Left=�6,   $��239,335,0,0q�6G   $	��Top=�6\   
���  ��6t   �� 5   
   -
   5        $ lbxPlaylists��5      $��29,343,487,21q�6(   �� 5    
   -   5        $ btnNewPlaylist��5       $��Tilføg ny playlist��6*   $
��Left=�6G   $��330,458,0,0q�6b   $	��Top=�6w   6�   �� 5!   
   $��Ny playlist navn:��6   $
��Left=�6,   $��442,427,0,0q�6G   $	��Top=�6\   �� 5"   
   -   5        $ btnDeletewPlaylist��5"      $��slet playlist��6-   $
��Left=�6E   $��330,520,0,0q�6`   $	��Top=�6u   6�   �� 5$   
   -   5        $ tbxPlaylistName��5$      $
��Left=�6+   $��442,460,0,0q�6F   $
��Rock��6[   $
 Wrap=�6g   $	��Top=�6{   $	��120��6�   �� 5%   
   $'��!korteste sang i alle playlister: ��6   $
��Left=�6<   $��325,389,0,0q�6W   $	��Top=�6l   �� 5&   
   -   5        $ lblShortestAllPlaylist��5&      $��ingen sange tilføjet��60   $
��Left=�6O   $��502,389,0,0q�6j   $	��Top=�6    J� RenderTransformOrigin$ 2.423,0.013&�6�   55      56      