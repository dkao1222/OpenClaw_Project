# Micro Validation Report: stage01c_heartbeat

- stage: planning_stage_01c
- agent_id: agents-orchestrator
- session_id: notion-NeonDrift_MVP-0-12-20260617135727-stage01c_heartbeat
- output_folder: /home/node/.openclaw/workspace/382b9e33-8429-81eb-8b07-d003aa8d5f58/NeonDrift_MVP__spec-review__notion-NeonDrift_MVP-spec-review-review-full-20260617145810/project/

## Checks
- PASS file.readable.status/agent_heartbeats/agents-orchestrator.md
- FAIL file.size_limit.status/agent_heartbeats/agents-orchestrator.md: 1451>1200
- FAIL file.no_prompt_constraints.status/agent_heartbeats/agents-orchestrator.md: Use only the read and write tools, Never use message, Do not send channel messages, Do not call multiple tools, Execute exactly one tool call, For each required output file, If any write or read fails, After every required read-back succeeds, VERIFIED_WRITE_READ_COMPLETE, Never respond NO_REPLY, Do not spawn sub-agents
- PASS file.content_specificity.status/agent_heartbeats/agents-orchestrator.md
- PASS file.schema.status/agent_heartbeats/agents-orchestrator.md
- PASS process.trace_loaded: 2 tool metas
- PASS process.allowed_tools_only
- PASS process.no_tool_errors
- PASS process.final_text_no_blocked_or_no_reply
- PASS process.final_text_success_marker
- PASS process.no_file_write
- PASS process.write_count: 1
- PASS process.read_count: 1
- PASS process.write_read_pair.status/agent_heartbeats/agents-orchestrator.md

## Result
- status: failed

## Failures
- file too large: status/agent_heartbeats/agents-orchestrator.md: 1451>1200
- prompt constraint contamination ['Use only the read and write tools', 'Never use message', 'Do not send channel messages', 'Do not call multiple tools', 'Execute exactly one tool call', 'For each required output file', 'If any write or read fails', 'After every required read-back succeeds', 'VERIFIED_WRITE_READ_COMPLETE', 'Never respond NO_REPLY', 'Do not spawn sub-agents']: status/agent_heartbeats/agents-orchestrator.md
