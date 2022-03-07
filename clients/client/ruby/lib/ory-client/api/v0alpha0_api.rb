=begin
#Ory APIs

#Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 

The version of the OpenAPI document: v0.0.1-alpha.116
Contact: support@ory.sh
Generated by: https://openapi-generator.tech
OpenAPI Generator version: 5.4.0

=end

require 'cgi'

module OryClient
  class V0alpha0Api
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end
    # Create a Project
    # Creates a new project.
    # @param [Hash] opts the optional parameters
    # @option opts [ProjectRevision] :project_revision 
    # @return [Project]
    def create_project(opts = {})
      data, _status_code, _headers = create_project_with_http_info(opts)
      data
    end

    # Create a Project
    # Creates a new project.
    # @param [Hash] opts the optional parameters
    # @option opts [ProjectRevision] :project_revision 
    # @return [Array<(Project, Integer, Hash)>] Project data, response status code and response headers
    def create_project_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: V0alpha0Api.create_project ...'
      end
      # resource path
      local_var_path = '/backoffice/public/projects'

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json'])
      # HTTP header 'Content-Type'
      content_type = @api_client.select_header_content_type(['application/json'])
      if !content_type.nil?
          header_params['Content-Type'] = content_type
      end

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:debug_body] || @api_client.object_to_http_body(opts[:'project_revision'])

      # return_type
      return_type = opts[:debug_return_type] || 'Project'

      # auth_names
      auth_names = opts[:debug_auth_names] || ['oryAccessToken']

      new_options = opts.merge(
        :operation => :"V0alpha0Api.create_project",
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:POST, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: V0alpha0Api#create_project\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Returns Your Active Ory Cloud Project
    # Use this API to get your active project in the Ory Cloud Console UI.
    # @param [Hash] opts the optional parameters
    # @return [ActiveProject]
    def get_active_project(opts = {})
      data, _status_code, _headers = get_active_project_with_http_info(opts)
      data
    end

    # Returns Your Active Ory Cloud Project
    # Use this API to get your active project in the Ory Cloud Console UI.
    # @param [Hash] opts the optional parameters
    # @return [Array<(ActiveProject, Integer, Hash)>] ActiveProject data, response status code and response headers
    def get_active_project_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: V0alpha0Api.get_active_project ...'
      end
      # resource path
      local_var_path = '/backoffice/public/console/projects/active'

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json'])

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:debug_body]

      # return_type
      return_type = opts[:debug_return_type] || 'ActiveProject'

      # auth_names
      auth_names = opts[:debug_auth_names] || ['oryAccessToken']

      new_options = opts.merge(
        :operation => :"V0alpha0Api.get_active_project",
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:GET, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: V0alpha0Api#get_active_project\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Get a Project
    # Get a projects you have access to by its ID.
    # @param project_id [String] Project ID  The project&#39;s ID.
    # @param [Hash] opts the optional parameters
    # @return [Project]
    def get_project(project_id, opts = {})
      data, _status_code, _headers = get_project_with_http_info(project_id, opts)
      data
    end

    # Get a Project
    # Get a projects you have access to by its ID.
    # @param project_id [String] Project ID  The project&#39;s ID.
    # @param [Hash] opts the optional parameters
    # @return [Array<(Project, Integer, Hash)>] Project data, response status code and response headers
    def get_project_with_http_info(project_id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: V0alpha0Api.get_project ...'
      end
      # verify the required parameter 'project_id' is set
      if @api_client.config.client_side_validation && project_id.nil?
        fail ArgumentError, "Missing the required parameter 'project_id' when calling V0alpha0Api.get_project"
      end
      # resource path
      local_var_path = '/backoffice/public/projects/{project_id}'.sub('{' + 'project_id' + '}', CGI.escape(project_id.to_s))

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json'])

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:debug_body]

      # return_type
      return_type = opts[:debug_return_type] || 'Project'

      # auth_names
      auth_names = opts[:debug_auth_names] || ['oryAccessToken']

      new_options = opts.merge(
        :operation => :"V0alpha0Api.get_project",
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:GET, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: V0alpha0Api#get_project\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Get all members associated with this project.
    # This endpoint requires the user to be a member of the project with the role `OWNER` or `DEVELOPER`.
    # @param project_id [String] Project ID  The project&#39;s ID.
    # @param [Hash] opts the optional parameters
    # @return [Array<CloudAccount>]
    def get_project_members(project_id, opts = {})
      data, _status_code, _headers = get_project_members_with_http_info(project_id, opts)
      data
    end

    # Get all members associated with this project.
    # This endpoint requires the user to be a member of the project with the role &#x60;OWNER&#x60; or &#x60;DEVELOPER&#x60;.
    # @param project_id [String] Project ID  The project&#39;s ID.
    # @param [Hash] opts the optional parameters
    # @return [Array<(Array<CloudAccount>, Integer, Hash)>] Array<CloudAccount> data, response status code and response headers
    def get_project_members_with_http_info(project_id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: V0alpha0Api.get_project_members ...'
      end
      # verify the required parameter 'project_id' is set
      if @api_client.config.client_side_validation && project_id.nil?
        fail ArgumentError, "Missing the required parameter 'project_id' when calling V0alpha0Api.get_project_members"
      end
      # resource path
      local_var_path = '/backoffice/public/projects/{project_id}/members'.sub('{' + 'project_id' + '}', CGI.escape(project_id.to_s))

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json'])

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:debug_body]

      # return_type
      return_type = opts[:debug_return_type] || 'Array<CloudAccount>'

      # auth_names
      auth_names = opts[:debug_auth_names] || ['oryAccessToken']

      new_options = opts.merge(
        :operation => :"V0alpha0Api.get_project_members",
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:GET, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: V0alpha0Api#get_project_members\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # List All Projects
    # Lists all projects you have access to.
    # @param [Hash] opts the optional parameters
    # @return [Array<Project>]
    def list_projects(opts = {})
      data, _status_code, _headers = list_projects_with_http_info(opts)
      data
    end

    # List All Projects
    # Lists all projects you have access to.
    # @param [Hash] opts the optional parameters
    # @return [Array<(Array<Project>, Integer, Hash)>] Array<Project> data, response status code and response headers
    def list_projects_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: V0alpha0Api.list_projects ...'
      end
      # resource path
      local_var_path = '/backoffice/public/projects'

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json'])

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:debug_body]

      # return_type
      return_type = opts[:debug_return_type] || 'Array<Project>'

      # auth_names
      auth_names = opts[:debug_auth_names] || ['oryAccessToken']

      new_options = opts.merge(
        :operation => :"V0alpha0Api.list_projects",
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:GET, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: V0alpha0Api#list_projects\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Irrecoverably Purge a Project
    # !! Use with extreme caution !!  Using this API endpoint you can purge (completely delete) a project and its data. This action can not be undone and will delete ALL your data.  !! Use with extreme caution !!
    # @param project_id [String] Project ID  The project&#39;s ID.
    # @param [Hash] opts the optional parameters
    # @return [nil]
    def purge_project(project_id, opts = {})
      purge_project_with_http_info(project_id, opts)
      nil
    end

    # Irrecoverably Purge a Project
    # !! Use with extreme caution !!  Using this API endpoint you can purge (completely delete) a project and its data. This action can not be undone and will delete ALL your data.  !! Use with extreme caution !!
    # @param project_id [String] Project ID  The project&#39;s ID.
    # @param [Hash] opts the optional parameters
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def purge_project_with_http_info(project_id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: V0alpha0Api.purge_project ...'
      end
      # verify the required parameter 'project_id' is set
      if @api_client.config.client_side_validation && project_id.nil?
        fail ArgumentError, "Missing the required parameter 'project_id' when calling V0alpha0Api.purge_project"
      end
      # resource path
      local_var_path = '/backoffice/public/projects/{project_id}'.sub('{' + 'project_id' + '}', CGI.escape(project_id.to_s))

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json'])

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:debug_body]

      # return_type
      return_type = opts[:debug_return_type]

      # auth_names
      auth_names = opts[:debug_auth_names] || ['oryAccessToken']

      new_options = opts.merge(
        :operation => :"V0alpha0Api.purge_project",
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:DELETE, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: V0alpha0Api#purge_project\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Remove a member associated with this project. This also sets their invite status to `REMOVED`.
    # This endpoint requires the user to be a member of the project with the role `OWNER`.
    # @param project_id [String] Project ID  The project&#39;s ID.
    # @param member_id [String] Member ID
    # @param [Hash] opts the optional parameters
    # @return [nil]
    def remove_project_member(project_id, member_id, opts = {})
      remove_project_member_with_http_info(project_id, member_id, opts)
      nil
    end

    # Remove a member associated with this project. This also sets their invite status to &#x60;REMOVED&#x60;.
    # This endpoint requires the user to be a member of the project with the role &#x60;OWNER&#x60;.
    # @param project_id [String] Project ID  The project&#39;s ID.
    # @param member_id [String] Member ID
    # @param [Hash] opts the optional parameters
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def remove_project_member_with_http_info(project_id, member_id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: V0alpha0Api.remove_project_member ...'
      end
      # verify the required parameter 'project_id' is set
      if @api_client.config.client_side_validation && project_id.nil?
        fail ArgumentError, "Missing the required parameter 'project_id' when calling V0alpha0Api.remove_project_member"
      end
      # verify the required parameter 'member_id' is set
      if @api_client.config.client_side_validation && member_id.nil?
        fail ArgumentError, "Missing the required parameter 'member_id' when calling V0alpha0Api.remove_project_member"
      end
      # resource path
      local_var_path = '/backoffice/public/projects/{project_id}/members/{member_id}'.sub('{' + 'project_id' + '}', CGI.escape(project_id.to_s)).sub('{' + 'member_id' + '}', CGI.escape(member_id.to_s))

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json'])

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:debug_body]

      # return_type
      return_type = opts[:debug_return_type]

      # auth_names
      auth_names = opts[:debug_auth_names] || ['oryAccessToken']

      new_options = opts.merge(
        :operation => :"V0alpha0Api.remove_project_member",
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:DELETE, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: V0alpha0Api#remove_project_member\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Sets Your Active Project
    # Use this API to set your active project in the Ory Cloud Console UI.
    # @param [Hash] opts the optional parameters
    # @option opts [InlineObject] :inline_object 
    # @return [nil]
    def set_active_project(opts = {})
      set_active_project_with_http_info(opts)
      nil
    end

    # Sets Your Active Project
    # Use this API to set your active project in the Ory Cloud Console UI.
    # @param [Hash] opts the optional parameters
    # @option opts [InlineObject] :inline_object 
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def set_active_project_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: V0alpha0Api.set_active_project ...'
      end
      # resource path
      local_var_path = '/backoffice/public/console/projects/active'

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json'])
      # HTTP header 'Content-Type'
      content_type = @api_client.select_header_content_type(['application/json'])
      if !content_type.nil?
          header_params['Content-Type'] = content_type
      end

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:debug_body] || @api_client.object_to_http_body(opts[:'inline_object'])

      # return_type
      return_type = opts[:debug_return_type]

      # auth_names
      auth_names = opts[:debug_auth_names] || ['oryAccessToken']

      new_options = opts.merge(
        :operation => :"V0alpha0Api.set_active_project",
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:PUT, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: V0alpha0Api#set_active_project\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Update a Project
    # Creates a new configuration revision for a project.
    # @param project_id [String] Project ID  The project&#39;s ID.
    # @param [Hash] opts the optional parameters
    # @option opts [ProjectRevision] :project_revision 
    # @return [Project]
    def update_project(project_id, opts = {})
      data, _status_code, _headers = update_project_with_http_info(project_id, opts)
      data
    end

    # Update a Project
    # Creates a new configuration revision for a project.
    # @param project_id [String] Project ID  The project&#39;s ID.
    # @param [Hash] opts the optional parameters
    # @option opts [ProjectRevision] :project_revision 
    # @return [Array<(Project, Integer, Hash)>] Project data, response status code and response headers
    def update_project_with_http_info(project_id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: V0alpha0Api.update_project ...'
      end
      # verify the required parameter 'project_id' is set
      if @api_client.config.client_side_validation && project_id.nil?
        fail ArgumentError, "Missing the required parameter 'project_id' when calling V0alpha0Api.update_project"
      end
      # resource path
      local_var_path = '/backoffice/public/projects/{project_id}'.sub('{' + 'project_id' + '}', CGI.escape(project_id.to_s))

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json'])
      # HTTP header 'Content-Type'
      content_type = @api_client.select_header_content_type(['application/json'])
      if !content_type.nil?
          header_params['Content-Type'] = content_type
      end

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:debug_body] || @api_client.object_to_http_body(opts[:'project_revision'])

      # return_type
      return_type = opts[:debug_return_type] || 'Project'

      # auth_names
      auth_names = opts[:debug_auth_names] || ['oryAccessToken']

      new_options = opts.merge(
        :operation => :"V0alpha0Api.update_project",
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:PUT, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: V0alpha0Api#update_project\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Update an Ory Cloud Project Configuration
    # This endpoints allows you to update the Ory Cloud Project configuration for individual services (identity, permission, ...). The configuration is fully compatible with the open source projects for the respective services (e.g. Ory Kratos for Identity, Ory Keto for Permissions).  This endpoint expects the `version` key to be set in the payload. If it is unset, it will try to import the config as if it is from the most recent version.  If you have an older version of a configuration, you should set the version key in the payload!  While this endpoint is able to process all configuration items related to features (e.g. password reset), it does not support operational configuration items (e.g. port, tracing, logging) otherwise available in the open source.  For configuration items that can not be translated to Ory Cloud, this endpoint will return a list of warnings to help you understand which parts of your config could not be processed.  Be aware that updating any service's configuration will completely override your current configuration for that service!
    # @param project_id [String] Project ID  The project&#39;s ID.
    # @param [Hash] opts the optional parameters
    # @option opts [UpdateProjectConfigConfig] :update_project_config_config 
    # @return [SuccessfulProjectConfigUpdate]
    def update_project_config(project_id, opts = {})
      data, _status_code, _headers = update_project_config_with_http_info(project_id, opts)
      data
    end

    # Update an Ory Cloud Project Configuration
    # This endpoints allows you to update the Ory Cloud Project configuration for individual services (identity, permission, ...). The configuration is fully compatible with the open source projects for the respective services (e.g. Ory Kratos for Identity, Ory Keto for Permissions).  This endpoint expects the &#x60;version&#x60; key to be set in the payload. If it is unset, it will try to import the config as if it is from the most recent version.  If you have an older version of a configuration, you should set the version key in the payload!  While this endpoint is able to process all configuration items related to features (e.g. password reset), it does not support operational configuration items (e.g. port, tracing, logging) otherwise available in the open source.  For configuration items that can not be translated to Ory Cloud, this endpoint will return a list of warnings to help you understand which parts of your config could not be processed.  Be aware that updating any service&#39;s configuration will completely override your current configuration for that service!
    # @param project_id [String] Project ID  The project&#39;s ID.
    # @param [Hash] opts the optional parameters
    # @option opts [UpdateProjectConfigConfig] :update_project_config_config 
    # @return [Array<(SuccessfulProjectConfigUpdate, Integer, Hash)>] SuccessfulProjectConfigUpdate data, response status code and response headers
    def update_project_config_with_http_info(project_id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: V0alpha0Api.update_project_config ...'
      end
      # verify the required parameter 'project_id' is set
      if @api_client.config.client_side_validation && project_id.nil?
        fail ArgumentError, "Missing the required parameter 'project_id' when calling V0alpha0Api.update_project_config"
      end
      # resource path
      local_var_path = '/backoffice/public/projects/{project_id}/configs'.sub('{' + 'project_id' + '}', CGI.escape(project_id.to_s))

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json'])
      # HTTP header 'Content-Type'
      content_type = @api_client.select_header_content_type(['application/json'])
      if !content_type.nil?
          header_params['Content-Type'] = content_type
      end

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:debug_body] || @api_client.object_to_http_body(opts[:'update_project_config_config'])

      # return_type
      return_type = opts[:debug_return_type] || 'SuccessfulProjectConfigUpdate'

      # auth_names
      auth_names = opts[:debug_auth_names] || ['oryAccessToken']

      new_options = opts.merge(
        :operation => :"V0alpha0Api.update_project_config",
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:PUT, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: V0alpha0Api#update_project_config\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end
