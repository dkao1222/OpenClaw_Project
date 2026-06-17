# Micro Validation Report: stage01e_handoff_package

- stage: planning_stage_01e
- agent_id: agents-orchestrator
- session_id: notion-NeonDrift_MVP-0-12-20260617135727-stage01e_handoff_package
- output_folder: /home/node/.openclaw/workspace/382b9e33-8429-81e5-b017-e72d6bcabc4d/NeonDrift_MVP__test__notion-NeonDrift_MVP-0-12-20260617135727/project/

## Checks
- FAIL file.exists.handoffs/planning/01_agents-orchestrator_to_product-planner.md: missing
- FAIL process.trace_loaded: /home/node/.openclaw/agents/agents-orchestrator/sessions/notion-NeonDrift_MVP-0-12-20260617135727-stage01e_handoff_package.trajectory.jsonl
- PASS process.allowed_tools_only
- PASS process.no_tool_errors
- PASS process.final_text_no_blocked_or_no_reply
- FAIL process.final_text_success_marker: '' in /home/node/.openclaw/agents/agents-orchestrator/sessions/notion-NeonDrift_MVP-0-12-20260617135727-stage01e_handoff_package.jsonl
- PASS process.no_file_write
- FAIL process.write_count: 0
- FAIL process.read_count: 0
- FAIL process.write_read_pair.handoffs/planning/01_agents-orchestrator_to_product-planner.md

## Result
- status: failed

## Failures
- missing file: handoffs/planning/01_agents-orchestrator_to_product-planner.md
- missing trajectory toolMetas: /home/node/.openclaw/agents/agents-orchestrator/sessions/notion-NeonDrift_MVP-0-12-20260617135727-stage01e_handoff_package.trajectory.jsonl
- final assistant success marker must be exactly VERIFIED_WRITE_READ_COMPLETE
- insufficient write count: expected at least 1, actual 0
- insufficient readback count: expected at least 1, actual 0
- missing write/read pair: handoffs/planning/01_agents-orchestrator_to_product-planner.md
