<!DOCTYPE html>
<html>
  <head>
	<title><%= title %></title>
	<%= csrf_meta_tag %>
	<%= render 'layouts/stylesheets' %>
  </head>
  <body>
	<div class="container">
	  <%= render 'layouts/header' %>
	  <section class="round">
		<%= yield %>
	  </section>
	  <%= render 'layouts/footer' %>
	</div>
  </body>
</html>
