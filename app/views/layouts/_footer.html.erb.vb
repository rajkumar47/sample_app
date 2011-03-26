<!DOCTYPE html>
<html>
<head>
  <title><%= title %></title>
  <%= csrf_meta_tag %>
</head>
<body>
<div class="container">
	<header>
		<%= image_tag("logo.png", :alt => "Sample App", :class => 'round') %>
		<nav class="round">
			<ul>
				<li><%= link_to "Home", '#' %></li>
				<li><%= link_to "Help", '#' %></li>
				<li><%= link_to "Sign in", '#' %></li>
			</ul>
		</nav>
	</header>
	<section class="round">
		<%= yield %>
	</section>
</div>
</body>
</html>
